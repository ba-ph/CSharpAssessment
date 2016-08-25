using System;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

public class SerializationHelper
{
	public SerializationHelper()
	{
	}

    //XMLSerialization
    public static void SerializeForm(string a_path, Form a_object)
    {
        XmlTextWriter xmlSerialisedForm = new XmlTextWriter("tree save", System.Text.Encoding.Default);
        xmlSerialisedForm.Formatting = Formatting.Indented;

        //create a streamwriter to write to file
        StreamWriter writer = new StreamWriter(a_path);

        //create an XMLSerializer to serialize
        XmlSerializer serializer = new XmlSerializer(typeof(Form));

        //serialize
        serializer.Serialize(writer, a_object);

        //close writer
        writer.Close();
    }

    public static Form DeserializeForm(string a_path)
    {
        //create a streamwriter to write to file
        StreamReader reader = new StreamReader(a_path);

        //create an XMLSerializer to serialize
        XmlSerializer serializer = new XmlSerializer(typeof(Form));

        //serialize
        Form newPlayer = serializer.Deserialize(reader) as Form;

        //close writer
        reader.Close();

        //return newplayer
        return newPlayer;

    }

}
