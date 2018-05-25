package edu.dongvv2.dao;

import java.util.Map;
import java.util.Set;

import edu.dongvv2.beans.Product;

public interface CartDAO {
	public Map<Product, Integer> getContents();
	public Set<Product> getProducts();
	public void addProduct(Product product, int count);
	public void removeProduct(Product product);
	public void clearCart();
	public double getTotalCost();
}
