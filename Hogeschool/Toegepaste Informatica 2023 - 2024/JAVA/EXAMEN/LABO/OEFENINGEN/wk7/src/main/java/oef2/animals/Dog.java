package oef2.animals;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;

import java.time.LocalDate;
import java.util.Objects;

@Entity
public class Dog extends Animal implements DomesticatedAnimal, FourLeggedAnimal {
    private static final String SOUND = "Barks";

    @Column(name = "dog_breed")
    @Enumerated(value = EnumType.STRING)
    private DogBreed breed;

    public Dog() {
    }

    public Dog(String name, DogBreed breed, Gender gender, LocalDate dateOfBirth) {
        super(name, gender, dateOfBirth);
        this.breed = breed;
    }

    @Override
    public void makeSound() {
        System.out.println(SOUND);
    }

    @Override
    public String toString() {
        return "Dog{" +
                "breed=" + breed +
                "} " + super.toString();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        Dog dog = (Dog) o;
        return breed == dog.breed;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), breed);
    }
}
