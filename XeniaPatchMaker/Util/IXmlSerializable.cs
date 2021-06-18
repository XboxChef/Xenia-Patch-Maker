namespace XeniaPatchMaker.Util
{
    /// <summary>
    /// Defines a class that is capable of de/serializing itself.
    /// </summary>
    public interface IXmlSerializable<T> where T : IXmlSerializable<T>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="indent"></param>
        /// <param name="indentAttributes"></param>
        /// <returns></returns>
        string XmlSerialize(bool indent = false, bool indentAttributes = false);
    }
}
