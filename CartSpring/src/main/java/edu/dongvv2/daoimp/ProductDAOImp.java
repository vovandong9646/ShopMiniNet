package edu.dongvv2.daoimp;

import java.util.ArrayList;

import java.util.List;

import org.springframework.stereotype.Repository;

import edu.dongvv2.beans.Product;
import edu.dongvv2.dao.ProductDAO;

@Repository
public class ProductDAOImp implements ProductDAO{

	public List<Product> getAll() {
		
		List<Product> listProduct = new ArrayList<Product>();
		
		listProduct.add(new Product(1,"Iphone","D:\\image\\Iphone.jpg","01235", 11));
		listProduct.add(new Product(2,"Sam Sung","D:\\image\\SamSung.jpg","12345", 23));
		listProduct.add(new Product(3,"Oppo","D:\\image\\Oppo.jpg","12354", 43));
		listProduct.add(new Product(4,"Android","D:\\image\\Android.jpg","546744", 22));
		listProduct.add(new Product(5,"Nokia","D:\\image\\Nokia.jpg","3423545", 11));
		listProduct.add(new Product(6,"Xaomi","D:\\image\\Xaomi.jpg","2354576", 22));
		listProduct.add(new Product(7,"Zenfone","D:\\image\\Zenfone.jpg","343656", 33));
		listProduct.add(new Product(8,"Asus","D:\\image\\Asus.jpg","767834", 44));
		listProduct.add(new Product(9,"Huawei","D:\\image\\Huawei.jpg","2354565", 55));
		listProduct.add(new Product(10,"Vivo","D:\\image\\Vivo.jpg","4343454", 66));
		
		return listProduct;
	}

	public Product findByID(int id) {
		Product result = null;
		for(Product product : this.getAll()) {
			if(product.getId() == id) {
				result = product;
			}
		}
		return result;
	}
	
}
