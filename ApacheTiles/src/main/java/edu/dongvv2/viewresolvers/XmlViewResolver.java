package edu.dongvv2.viewresolvers;

import java.util.Locale;

import javax.xml.bind.Marshaller;

import org.springframework.web.servlet.View;
import org.springframework.web.servlet.ViewResolver;
import org.springframework.web.servlet.view.xml.MarshallingView;

public class XmlViewResolver implements ViewResolver {
	
	private Marshaller marshaller;
	
	
	public Marshaller getMarshaller() {
		return marshaller;
	}


	public void setMarshaller(Marshaller marshaller) {
		this.marshaller = marshaller;
	}


	public View resolveViewName(String viewName, Locale locale) throws Exception {
		MarshallingView view = new MarshallingView();
		//view.setMarshaller(this.marshaller);
		return view;
	}

}
