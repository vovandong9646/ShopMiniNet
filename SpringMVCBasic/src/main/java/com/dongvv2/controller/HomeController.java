package com.dongvv2.controller;

import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

import com.dongvv2.model.User;

@Controller
public class HomeController {

	@RequestMapping("/")
	public String index() {
		
		return "home";
	}
	
	@RequestMapping(value="/users", method=RequestMethod.POST)
	@ResponseBody
	public String userAction(@ModelAttribute("UserModel") User user, BindingResult result) {
		
		if(result.hasErrors()) {
			System.out.println("Có lỗi rồi nhé");
		}
		System.out.println(user.getAge());
		System.out.println(user.getFirstname());
		System.out.println(user.getLastname());
		
		return "abc";
	}
}
