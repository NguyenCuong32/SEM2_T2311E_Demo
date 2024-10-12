package org.fai.study.demo_springboot.controllers;

import org.fai.study.demo_springboot.entities.ClassRoom;
import org.fai.study.demo_springboot.services.ClassRoomService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("api/v1/classroom")
public class ClassRoomController {
    @Autowired
    private ClassRoomService classRoomService;
    @GetMapping("")
    public List<ClassRoom> getAllClassRoom(){
        var classRooms = this.classRoomService.getClassRooms();
        return classRooms;
    }

}
