package edu.dongvv2.serviceimps;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.dongvv2.beans.Product;
import edu.dongvv2.dao.ProductDAO;
import edu.dongvv2.services.ProductService;

@Service
public class ProductServiceImp implements ProductService{

	@Autowired
	public ProductDAO productDAO;
	
	public List<Product> getListProduct() {
		return productDAO.getAll();
	}

	 
}
