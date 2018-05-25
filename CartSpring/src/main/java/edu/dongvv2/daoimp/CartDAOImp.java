package edu.dongvv2.daoimp;

import java.util.HashMap;
import java.util.Map;
import java.util.Set;

import org.springframework.context.annotation.Scope;
import org.springframework.context.annotation.ScopedProxyMode;
import org.springframework.stereotype.Component;
import org.springframework.web.context.WebApplicationContext;

import edu.dongvv2.beans.Product;
import edu.dongvv2.dao.CartDAO;

@Component
@Scope(value=WebApplicationContext.SCOPE_SESSION, proxyMode=ScopedProxyMode.TARGET_CLASS)
public class CartDAOImp implements CartDAO {
	
	private Map<Product, Integer> contents = new HashMap<Product, Integer>();
	
	public Map<Product, Integer> getContents() {
		return this.contents;
	}

	public Set<Product> getProducts() {
		return this.contents.keySet();
	}

	@Override
	public String toString() {
		return "CartDAOImp [contents=" + contents + "]";
	}

	public void addProduct(Product product, int count) {
		if(contents.containsKey(product)) {
			contents.put(product, contents.get(product) + count);
		} else {
			contents.put(product, count);
		}
		
	}

	public void removeProduct(Product product) {
		if(contents.containsKey(product)) {
			contents.remove(product);
		}
	}

	public void clearCart() {
		contents.clear();
	}

	public double getTotalCost() {
		double totalCost = 0;
		for(Product product : this.contents.keySet()) {
			totalCost += (Integer.parseInt(product.getPrice()));
		}
		return totalCost;
	}

}
