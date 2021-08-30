/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;

namespace PnPTypes
{
    #region HeaderDataType Class
    #if (!OPCUA_EXCLUDE_HeaderDataType)
    /// <summary>
    /// Standard metadata for higher-level stamped data types
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class HeaderDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public HeaderDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_sequenceID = (uint)0;
            m_stamp = DateTime.MinValue;
            m_frameID = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "SequenceID", IsRequired = false, Order = 1)]
        public uint SequenceID
        {
            get { return m_sequenceID;  }
            set { m_sequenceID = value; }
        }

        /// <remarks />
        [DataMember(Name = "Stamp", IsRequired = false, Order = 2)]
        public DateTime Stamp
        {
            get { return m_stamp;  }
            set { m_stamp = value; }
        }

        /// <remarks />
        [DataMember(Name = "FrameID", IsRequired = false, Order = 3)]
        public string FrameID
        {
            get { return m_frameID;  }
            set { m_frameID = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.HeaderDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.HeaderDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.HeaderDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteUInt32("SequenceID", SequenceID);
            encoder.WriteDateTime("Stamp", Stamp);
            encoder.WriteString("FrameID", FrameID);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            SequenceID = decoder.ReadUInt32("SequenceID");
            Stamp = decoder.ReadDateTime("Stamp");
            FrameID = decoder.ReadString("FrameID");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            HeaderDataType value = encodeable as HeaderDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_sequenceID, value.m_sequenceID)) return false;
            if (!Utils.IsEqual(m_stamp, value.m_stamp)) return false;
            if (!Utils.IsEqual(m_frameID, value.m_frameID)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (HeaderDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            HeaderDataType clone = (HeaderDataType)base.MemberwiseClone();

            clone.m_sequenceID = (uint)Utils.Clone(this.m_sequenceID);
            clone.m_stamp = (DateTime)Utils.Clone(this.m_stamp);
            clone.m_frameID = (string)Utils.Clone(this.m_frameID);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_sequenceID;
        private DateTime m_stamp;
        private string m_frameID;
        #endregion
    }

    #region HeaderDataTypeCollection Class
    /// <summary>
    /// A collection of HeaderDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfHeaderDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "HeaderDataType")]
    #if !NET_STANDARD
    public partial class HeaderDataTypeCollection : List<HeaderDataType>, ICloneable
    #else
    public partial class HeaderDataTypeCollection : List<HeaderDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public HeaderDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public HeaderDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public HeaderDataTypeCollection(IEnumerable<HeaderDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator HeaderDataTypeCollection(HeaderDataType[] values)
        {
            if (values != null)
            {
                return new HeaderDataTypeCollection(values);
            }

            return new HeaderDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator HeaderDataType[](HeaderDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (HeaderDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            HeaderDataTypeCollection clone = new HeaderDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((HeaderDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ImageDataType Class
    #if (!OPCUA_EXCLUDE_ImageDataType)
    /// <summary>
    /// Represents an Image Message. Defines the object where image frames are saved into. Definition based on ROS sensor_msgs/Image Message
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class ImageDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ImageDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_header = new HeaderDataType();
            m_data = null;
            m_step = (uint)0;
            m_encoding = null;
            m_height = (uint)0;
            m_width = (uint)0;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Header", IsRequired = false, Order = 1)]
        public HeaderDataType Header
        {
            get
            {
                return m_header;
            }

            set
            {
                m_header = value;

                if (value == null)
                {
                    m_header = new HeaderDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Data", IsRequired = false, Order = 2)]
        public byte[] Data
        {
            get { return m_data;  }
            set { m_data = value; }
        }

        /// <remarks />
        [DataMember(Name = "Step", IsRequired = false, Order = 3)]
        public uint Step
        {
            get { return m_step;  }
            set { m_step = value; }
        }

        /// <remarks />
        [DataMember(Name = "Encoding", IsRequired = false, Order = 4)]
        public string Encoding
        {
            get { return m_encoding;  }
            set { m_encoding = value; }
        }

        /// <remarks />
        [DataMember(Name = "Height", IsRequired = false, Order = 5)]
        public uint Height
        {
            get { return m_height;  }
            set { m_height = value; }
        }

        /// <remarks />
        [DataMember(Name = "Width", IsRequired = false, Order = 6)]
        public uint Width
        {
            get { return m_width;  }
            set { m_width = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ImageDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ImageDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ImageDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteEncodeable("Header", Header, typeof(HeaderDataType));
            encoder.WriteByteString("Data", Data);
            encoder.WriteUInt32("Step", Step);
            encoder.WriteString("Encoding", Encoding);
            encoder.WriteUInt32("Height", Height);
            encoder.WriteUInt32("Width", Width);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            Header = (HeaderDataType)decoder.ReadEncodeable("Header", typeof(HeaderDataType));
            Data = decoder.ReadByteString("Data");
            Step = decoder.ReadUInt32("Step");
            Encoding = decoder.ReadString("Encoding");
            Height = decoder.ReadUInt32("Height");
            Width = decoder.ReadUInt32("Width");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ImageDataType value = encodeable as ImageDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_header, value.m_header)) return false;
            if (!Utils.IsEqual(m_data, value.m_data)) return false;
            if (!Utils.IsEqual(m_step, value.m_step)) return false;
            if (!Utils.IsEqual(m_encoding, value.m_encoding)) return false;
            if (!Utils.IsEqual(m_height, value.m_height)) return false;
            if (!Utils.IsEqual(m_width, value.m_width)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ImageDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ImageDataType clone = (ImageDataType)base.MemberwiseClone();

            clone.m_header = (HeaderDataType)Utils.Clone(this.m_header);
            clone.m_data = (byte[])Utils.Clone(this.m_data);
            clone.m_step = (uint)Utils.Clone(this.m_step);
            clone.m_encoding = (string)Utils.Clone(this.m_encoding);
            clone.m_height = (uint)Utils.Clone(this.m_height);
            clone.m_width = (uint)Utils.Clone(this.m_width);

            return clone;
        }
        #endregion

        #region Private Fields
        private HeaderDataType m_header;
        private byte[] m_data;
        private uint m_step;
        private string m_encoding;
        private uint m_height;
        private uint m_width;
        #endregion
    }

    #region ImageDataTypeCollection Class
    /// <summary>
    /// A collection of ImageDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfImageDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "ImageDataType")]
    #if !NET_STANDARD
    public partial class ImageDataTypeCollection : List<ImageDataType>, ICloneable
    #else
    public partial class ImageDataTypeCollection : List<ImageDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ImageDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ImageDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ImageDataTypeCollection(IEnumerable<ImageDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ImageDataTypeCollection(ImageDataType[] values)
        {
            if (values != null)
            {
                return new ImageDataTypeCollection(values);
            }

            return new ImageDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ImageDataType[](ImageDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ImageDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ImageDataTypeCollection clone = new ImageDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ImageDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PoseDataType Class
    #if (!OPCUA_EXCLUDE_PoseDataType)
    /// <summary>
    /// A representation of pose in free space, composed of position and orientation
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class PoseDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public PoseDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.PoseDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.PoseDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.PoseDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PoseDataType value = encodeable as PoseDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PoseDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PoseDataType clone = (PoseDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region PoseDataTypeCollection Class
    /// <summary>
    /// A collection of PoseDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPoseDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "PoseDataType")]
    #if !NET_STANDARD
    public partial class PoseDataTypeCollection : List<PoseDataType>, ICloneable
    #else
    public partial class PoseDataTypeCollection : List<PoseDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PoseDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PoseDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PoseDataTypeCollection(IEnumerable<PoseDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PoseDataTypeCollection(PoseDataType[] values)
        {
            if (values != null)
            {
                return new PoseDataTypeCollection(values);
            }

            return new PoseDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PoseDataType[](PoseDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PoseDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PoseDataTypeCollection clone = new PoseDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PoseDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MarkerDataType Class
    #if (!OPCUA_EXCLUDE_MarkerDataType)
    /// <summary>
    /// Contains the elements representing a Fiducial Marker
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class MarkerDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MarkerDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_header = new HeaderDataType();
            m_pose = new PoseDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Header", IsRequired = false, Order = 1)]
        public HeaderDataType Header
        {
            get
            {
                return m_header;
            }

            set
            {
                m_header = value;

                if (value == null)
                {
                    m_header = new HeaderDataType();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Pose", IsRequired = false, Order = 2)]
        public PoseDataType Pose
        {
            get
            {
                return m_pose;
            }

            set
            {
                m_pose = value;

                if (value == null)
                {
                    m_pose = new PoseDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MarkerDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MarkerDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MarkerDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteEncodeable("Header", Header, typeof(HeaderDataType));
            encoder.WriteEncodeable("Pose", Pose, typeof(PoseDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            Header = (HeaderDataType)decoder.ReadEncodeable("Header", typeof(HeaderDataType));
            Pose = (PoseDataType)decoder.ReadEncodeable("Pose", typeof(PoseDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MarkerDataType value = encodeable as MarkerDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_header, value.m_header)) return false;
            if (!Utils.IsEqual(m_pose, value.m_pose)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MarkerDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerDataType clone = (MarkerDataType)base.MemberwiseClone();

            clone.m_header = (HeaderDataType)Utils.Clone(this.m_header);
            clone.m_pose = (PoseDataType)Utils.Clone(this.m_pose);

            return clone;
        }
        #endregion

        #region Private Fields
        private HeaderDataType m_header;
        private PoseDataType m_pose;
        #endregion
    }

    #region MarkerDataTypeCollection Class
    /// <summary>
    /// A collection of MarkerDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMarkerDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "MarkerDataType")]
    #if !NET_STANDARD
    public partial class MarkerDataTypeCollection : List<MarkerDataType>, ICloneable
    #else
    public partial class MarkerDataTypeCollection : List<MarkerDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MarkerDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MarkerDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MarkerDataTypeCollection(IEnumerable<MarkerDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MarkerDataTypeCollection(MarkerDataType[] values)
        {
            if (values != null)
            {
                return new MarkerDataTypeCollection(values);
            }

            return new MarkerDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MarkerDataType[](MarkerDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MarkerDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerDataTypeCollection clone = new MarkerDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MarkerDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CameraInfoDataType Class
    #if (!OPCUA_EXCLUDE_CameraInfoDataType)
    /// <summary>
    /// Contains the definition of camera callibration parameters
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class CameraInfoDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CameraInfoDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_distortionCoefficients = new DoubleCollection();
            m_cameraMatrix = new DoubleCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Camera Distortion Coefficients = [k1, k2, p1, p2, k3]
        /// </summary>
        [DataMember(Name = "DistortionCoefficients", IsRequired = false, Order = 1)]
        public DoubleCollection DistortionCoefficients
        {
            get
            {
                return m_distortionCoefficients;
            }

            set
            {
                m_distortionCoefficients = value;

                if (value == null)
                {
                    m_distortionCoefficients = new DoubleCollection();
                }
            }
        }

        /// <summary>
        /// Camera Matrix = [(fx,0,cx), (0,fy,cy), (0,0,1)]
        /// </summary>
        [DataMember(Name = "CameraMatrix", IsRequired = false, Order = 2)]
        public DoubleCollection CameraMatrix
        {
            get
            {
                return m_cameraMatrix;
            }

            set
            {
                m_cameraMatrix = value;

                if (value == null)
                {
                    m_cameraMatrix = new DoubleCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CameraInfoDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CameraInfoDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CameraInfoDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteDoubleArray("DistortionCoefficients", DistortionCoefficients);
            encoder.WriteDoubleArray("CameraMatrix", CameraMatrix);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            DistortionCoefficients = decoder.ReadDoubleArray("DistortionCoefficients");
            CameraMatrix = decoder.ReadDoubleArray("CameraMatrix");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CameraInfoDataType value = encodeable as CameraInfoDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_distortionCoefficients, value.m_distortionCoefficients)) return false;
            if (!Utils.IsEqual(m_cameraMatrix, value.m_cameraMatrix)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CameraInfoDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CameraInfoDataType clone = (CameraInfoDataType)base.MemberwiseClone();

            clone.m_distortionCoefficients = (DoubleCollection)Utils.Clone(this.m_distortionCoefficients);
            clone.m_cameraMatrix = (DoubleCollection)Utils.Clone(this.m_cameraMatrix);

            return clone;
        }
        #endregion

        #region Private Fields
        private DoubleCollection m_distortionCoefficients;
        private DoubleCollection m_cameraMatrix;
        #endregion
    }

    #region CameraInfoDataTypeCollection Class
    /// <summary>
    /// A collection of CameraInfoDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCameraInfoDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "CameraInfoDataType")]
    #if !NET_STANDARD
    public partial class CameraInfoDataTypeCollection : List<CameraInfoDataType>, ICloneable
    #else
    public partial class CameraInfoDataTypeCollection : List<CameraInfoDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CameraInfoDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CameraInfoDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CameraInfoDataTypeCollection(IEnumerable<CameraInfoDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CameraInfoDataTypeCollection(CameraInfoDataType[] values)
        {
            if (values != null)
            {
                return new CameraInfoDataTypeCollection(values);
            }

            return new CameraInfoDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CameraInfoDataType[](CameraInfoDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CameraInfoDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CameraInfoDataTypeCollection clone = new CameraInfoDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CameraInfoDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}