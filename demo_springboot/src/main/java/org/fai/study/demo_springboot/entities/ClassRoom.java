package org.fai.study.demo_springboot.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;

@Entity
public class ClassRoom {
    @Id
    private int id_class;
    private String class_name;
    private String number_member;

    public String getClass_name() {
        return class_name;
    }

    public void setClass_name(String class_name) {
        this.class_name = class_name;
    }

    public int getId_class() {
        return id_class;
    }

    public void setId_class(int id_class) {
        this.id_class = id_class;
    }

    public String getNumber_member() {
        return number_member;
    }

    public void setNumber_member(String number_member) {
        this.number_member = number_member;
    }

    public ClassRoom(String class_name, int id_class, String number_member) {
        this.class_name = class_name;
        this.id_class = id_class;
        this.number_member = number_member;
    }

    public ClassRoom() {
    }
}
