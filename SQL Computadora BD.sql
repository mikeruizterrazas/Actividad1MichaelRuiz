CREATE TABLE Computadora (
  id INT NOT NULL,
 nombre VARCHAR(255) NOT NULL,
  descripcion TEXT,
  precio DECIMAL(10,2) NOT NULL,
  fechafabricacion DATE,
  PRIMARY KEY (id)
);