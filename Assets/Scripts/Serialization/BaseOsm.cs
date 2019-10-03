using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class BaseOsm
{
    protected T GetAttribute<T>(string attrName, XmlAttributeCollection attributes)
    {
        //TODO: We are going to assume <attrName> exists in the collection
        string strValue = attributes[attrName].Value;
        return (T)Convert.ChangeType(strValue, typeof(T));
    }

}