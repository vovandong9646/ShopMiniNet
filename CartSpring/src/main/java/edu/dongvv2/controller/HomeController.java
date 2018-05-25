package edu.dongvv2.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import edu.dongvv2.services.ProductService;

@Controller
public class HomeController {

	@Autowired
	public ProductService productService;
	
	@RequestMapping("/")
	public String index(Model model) {
		model.addAttribute("listProducts", productService.getListProduct());
		return "home";
	}
}
