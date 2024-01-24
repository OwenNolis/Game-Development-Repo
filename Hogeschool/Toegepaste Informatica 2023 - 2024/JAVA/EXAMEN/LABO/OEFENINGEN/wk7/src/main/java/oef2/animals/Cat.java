package oef2.animals;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;

import java.time.LocalDate;
import java.util.Objects;

@Entity
public class Cat extends Animal implements DomesticatedAnimal, FourLeggedAnimal {
    private static final String SOUND = "Meows";

    @Column(name = "cat_breed")
    @Enumerated(value = EnumType.STRING)
    private CatBreed breed;

    public Cat() {
    }

    public Cat(String name, CatBreed breed, Gender gender, LocalDate dateOfBirth) {
        super(name, gender, dateOfBirth);
        this.breed = breed;
    }

    public void makeSound() {
        System.out.println(SOUND);
    }

    @Override
    public String toString() {
        return "Cat{" +
                "breed=" + breed +
                "} " + super.toString();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        Cat cat = (Cat) o;
        return breed == cat.breed;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), breed);
    }
}
