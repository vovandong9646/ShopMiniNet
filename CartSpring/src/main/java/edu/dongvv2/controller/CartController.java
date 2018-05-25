package edu.dongvv2.controller;

import org.apache.log4j.Logger;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ViewResolver;

import edu.dongvv2.beans.Product;
import edu.dongvv2.dao.CartDAO;
import edu.dongvv2.dao.ProductDAO;

@Controller
public class CartController {
	
	@Autowired
	public CartDAO cartDAO;
	
	@Autowired
	public ProductDAO productDAO;
	
	final static Logger logger = Logger.getLogger(CartController.class);
	
	@RequestMapping(path="/cart/add/{idProduct}", method=RequestMethod.GET)
	public String index(@PathVariable String idProduct) {
		
		int id = Integer.parseInt(idProduct);
		Product product = productDAO.findByID(id);
		cartDAO.addProduct(product, 1);
		
		logger.info(product.getName());
		
		return "redirect:/cart";
	}
	
	@RequestMapping("/cart")
	public String ShowContent(Model model) {
		model.addAttribute("carts", cartDAO);
		return "cart";
	}
}
