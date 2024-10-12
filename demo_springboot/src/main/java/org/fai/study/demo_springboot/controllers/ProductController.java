package org.fai.study.demo_springboot.controllers;

import org.fai.study.demo_springboot.entities.Product;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/api/v1/product")
public class ProductController {
    @GetMapping("/getproducts")
    public List<Product> getProducts() {
        List<Product> products = new ArrayList<>();
        Product product = new Product();
        product.setId(1);
        product.setName("Iphone");
        product.setPrice(50.00);
        product.setQty(5);
        products.add(product);
        Product product2 = new Product();
        product2.setId(1);
        product2.setName("Iphone");
        product2.setPrice(50.00);
        product2.setQty(5);
        products.add(product2);
        return products;
    }

}
