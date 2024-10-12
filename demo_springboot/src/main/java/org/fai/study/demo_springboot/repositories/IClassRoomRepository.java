package org.fai.study.demo_springboot.repositories;

import org.fai.study.demo_springboot.entities.ClassRoom;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface IClassRoomRepository extends JpaRepository<ClassRoom, Long> {
}
