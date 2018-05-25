package edu.dongvv2.dao;

import java.util.List;

import edu.dongvv2.beans.Product;

public interface ProductDAO {
	public List<Product> getAll();
	public Product findByID(int id);
}
