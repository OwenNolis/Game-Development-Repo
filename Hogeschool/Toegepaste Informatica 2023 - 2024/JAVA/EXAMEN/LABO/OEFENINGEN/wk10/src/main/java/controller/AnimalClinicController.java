package controller;

import java.util.List;
import java.util.stream.Collectors;

import entity.Animal;
import entity.AnimalType;
import entity.Consult;
import service.AnimalClinicService;

public class AnimalClinicController {

    private final AnimalClinicService service;

    public AnimalClinicController(AnimalClinicService service) {
        this.service = service;
    }

    public boolean createNewAnimal(AnimalDTO dto) {
        if (dto.getName() != null && dto.getType() != null && dto.getOwner() != null) {
            AnimalType type = AnimalType.valueOf(dto.getType());
            return service.addAnimal(dto.getName(), type, dto.getOwner());
        }
        return false;
    }

    public List<AnimalDTO> findAllAnimalsForOwner(String owner) {
        List<Animal> animals = service.findAllAnimalsForOwner(owner);
        return animals.stream().map(this::assemble).collect(Collectors.toList());
    }

    public AnimalDTO findAnimal(int id) {
        Animal animal = service.findAnimal(id);
        return assemble(animal);
    }

    public boolean createConsult(ConsultDTO dto) {
        return service.addConsult(dto.getAnimalId(), dto.getDate(), dto.getReason());
    }

    public List<ConsultDTO> findAllConsultsForAnimal(int animalId) {
        List<Consult> consults = service.findAllConsultsForAnimal(animalId);
        return consults.stream().map(this::assemble).collect(Collectors.toList());
    }

    private AnimalDTO assemble(Animal animal) {
        AnimalDTO dto = new AnimalDTO();
        dto.setId(animal.getId());
        dto.setName(animal.getName());
        dto.setType(animal.getType().toString());
        dto.setOwner(animal.getOwner());
        return dto;
    }

    private ConsultDTO assemble(Consult consult) {
        ConsultDTO dto = new ConsultDTO();
        dto.setId(consult.getId());
        dto.setAnimalId(consult.getAnimal().getId());
        dto.setDate(consult.getDate());
        dto.setReason(consult.getReason());
        return dto;
    }
}
