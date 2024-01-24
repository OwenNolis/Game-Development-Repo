package controller;

import java.time.LocalDate;

public class ConsultDTO {
    private int id;
    private int animalId;
    private LocalDate date;
    private String reason;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getAnimalId() {
        return animalId;
    }

    public void setAnimalId(int animalId) {
        this.animalId = animalId;
    }

    public LocalDate getDate() {
        return date;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    @Override
    public String toString() {
        return "ConsultDTO{" +
                "id=" + id +
                ", animalId=" + animalId +
                ", date=" + date +
                ", reason='" + reason + '\'' +
                '}';
    }
}
