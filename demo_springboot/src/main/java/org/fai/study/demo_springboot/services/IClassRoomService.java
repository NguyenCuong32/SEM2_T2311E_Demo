package org.fai.study.demo_springboot.services;

import org.fai.study.demo_springboot.entities.ClassRoom;
import org.springframework.stereotype.Service;

import java.util.List;

public interface IClassRoomService {
    List<ClassRoom> getClassRooms();
}
