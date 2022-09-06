using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListasForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Enero");
            listBox1.Items.Add("Febrero");
            listBox1.Items.Add("Marzo");
            listBox1.Items.Add("Abril");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(Convert.ToInt32(textBox2.Text), textBox1.Text);
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x;
            x = listBox1.Items.Count;
            MessageBox.Show(x.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x, y;                   // declarar dos variables de tipo entero
            x = listBox1.Items.Count;   // asignar a a x el total de registros de la lista
            for(y=0; y<x; y++)          // bucle  for(límite de inicio ; límite final; cambio (incremento / decremento)
            {                           // bucle se ejecuta tanta líneas tenga la lista
                listBox1.SelectedIndex = y;
                MessageBox.Show(listBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x, y;                   // declarar dos variables de tipo entero
            x = izquierda.Items.Count;   // asignar a a x el total de registros de la lista
            for (y = 0; y < x; y++)          // bucle  for(límite de inicio ; límite final; cambio (incremento / decremento)
            {                           // bucle se ejecuta tanta líneas tenga la lista
                izquierda.SelectedIndex = y;
                derecha.Items.Add(izquierda.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x, y;                   // declarar dos variables de tipo entero
            x = derecha.Items.Count;   // asignar a a x el total de registros de la lista
            for (y = 0; y < x; y++)          // bucle  for(límite de inicio ; límite final; cambio (incremento / decremento)
            {                           // bucle se ejecuta tanta líneas tenga la lista
                derecha.SelectedIndex = y;
                izquierda.Items.Add(izquierda.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            derecha.Items.Add(izquierda.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            izquierda.Items.Add(izquierda.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            izquierda.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            derecha.Items.Clear();
        }

        private void button14_Click(object sender, EventArgs e) // evento (método)
        {
            string archivo;                                         // declaraciones de las variables, archivo que guardará ruta y nombre de archivo
            string linea;                                           // almacena toda la línea de texto del archivo abierto
            StreamReader flujoentrada;                              // StreamReader es un tipo de datos que permite leer del flujo de entrada (un archivo)

            openFileDialog1.ShowDialog();                          // muestra el cuadro de diálogo de archivos
            archivo = openFileDialog1.FileName;                     // todo lo que hace el cuadro de diálogo es concatenar ruta y nombre de archivo, lo guarda en una variable archivo 
            flujoentrada = new StreamReader(archivo);               // creando el objeto flujoentrada y lo prepara para leer de la fuente "archivo", se abre el documento
            while((linea=flujoentrada.ReadLine()) != null)          // bucle para leer las líneas que tenga el archivo, su sintaxis sólo contiene una condición 
            {
                izquierda.Items.Add(linea);                         // se envía a la lista izquierda la línea leída
            }                                                       // termina bloque del bucle
        }

        // allowdrop de la lista derecha debe estar en true
        private void derecha_DragDrop(object sender, DragEventArgs e)       //método (evento) de arrastrar (drag) y soltar (drop), tiene dos argumentos
                                                                            // sender que es un objeto (tipo de dato genérico) (sender --> enviado), e es una variable que tiene
                                                                            // propiedades y métodos relacionados con el evento de arrastre y soltado
        {
            StreamReader flujoentrada;                                      // variable de flujo de entrada (leer del archivo)
            string linea;                                                   // variable de tipo cadena para almacenar todos los caracteres de la línea

            string[] cadena = (string[])e.Data.GetData(DataFormats.FileDrop, false);    // string[] cadena -->definimos cadena de tipo matriz string 
                                                                                        // (string[]) es un código que permite convertir a tipo matriz string
                                                                                        // e.Data.GetData(DataFormats.FileDrop, false)
                                                                                        // e.Data  invoca al método Data implícito en la variable e, generada por el evento DragDrop
                                                                                        // e.Data.GetData  queremos obtener datos muy específicos, obtiene los relacionados con el objeto arrastrado
                                                                                        // false, no se desea obtener ninguna conversión entre formatos
            int x;                                                          // variable que llevará el conteo de líneas
            for (x = 0; x < cadena.Length; x++)                             // bucle for que va de desde cero hasta longitud cadena -1, el incremento será de uno en uno
                ruta.Text=cadena[x];
                                                                              
            openFileDialog1.FileName = ruta.Text;                           // abre el archivo
            flujoentrada = new StreamReader(ruta.Text);                     // flujoentrada se crea y apunta al documento elegido y cuya ruta está almacenado en ruta
            while ((linea = flujoentrada.ReadLine()) != null)               // otro bucle para leer el contenido del archivo, línea por línea, hasta hallar el nulo
            {
                derecha.Items.Add(linea);                                   // agregar la línea leída del archivo
            }
        }

        private void derecha_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
