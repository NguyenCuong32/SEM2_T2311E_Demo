package org.fai.study.demo_springboot.services;

import org.fai.study.demo_springboot.entities.ClassRoom;
import org.fai.study.demo_springboot.repositories.IClassRoomRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
@Service
public class ClassRoomService implements IClassRoomService {

    private IClassRoomRepository classRoomRepository;
    @Autowired
   public ClassRoomService(IClassRoomRepository classRoomRepository){
   this.classRoomRepository = classRoomRepository;
   }
    @Override
    public List<ClassRoom> getClassRooms() {
        var classRooms = classRoomRepository.findAll();
        return classRooms;
    }
}
