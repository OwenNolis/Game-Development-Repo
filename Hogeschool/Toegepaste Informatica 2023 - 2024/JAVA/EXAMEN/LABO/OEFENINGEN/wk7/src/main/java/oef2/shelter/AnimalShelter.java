package oef2.shelter;

import oef2.animals.Animal;
import oef2.animals.Cat;
import oef2.animals.Dog;
import oef2.dao.AnimalDAO;
import oef2.dao.CatDAO;
import oef2.dao.DogDAO;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class AnimalShelter {
    private AnimalDAO animalDAO = new AnimalDAO();
    private CatDAO catDAO = new CatDAO();
    private DogDAO dogDAO = new DogDAO();

    public void addCat(Cat cat) throws DuplicateAnimalException {
        List<Animal> animals = animalDAO.findAllAnimals();
        for (Animal animal : animals) {
            if(animal instanceof Cat) {
                Cat existing = (Cat) animal;
                if(existing.equals(cat)) {
                    throw new DuplicateAnimalException();
                }
            }
        }
        catDAO.createCat(cat);
    }
    
    public void addDog(Dog dog) throws DuplicateAnimalException {
        List<Animal> animals = animalDAO.findAllAnimals();
        for (Animal animal : animals) {
            if(animal instanceof Dog) {
                Dog existing = (Dog) animal;
                if(existing.equals(dog)) {
                    throw new DuplicateAnimalException();
                }
            }
        }
        dogDAO.createDog(dog);
    }

    public void printAllAnimals() {
        List<Animal> animals = animalDAO.findAllAnimals();
        for (Animal animal : animals) {
            System.out.println(animal);
        }
    }

    public void showAnimal(int id) {
        Optional<Animal> animal = animalDAO.findById(id);
        animal.ifPresentOrElse(
                System.out::println,
                () -> System.out.println("Er is geen dier met id " + id)
        );
    }

    public void removeAnimal(int id) {
        Optional<Animal> animal = animalDAO.findById(id);
        animal.ifPresentOrElse(
                obj -> animalDAO.deleteAnimal(obj),
                () -> System.out.println("Er is geen dier met id " + id)
        );
    }
}
