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

namespace Camera
{
    #region ICameraInfoParameterState Class
    #if (!OPCUA_EXCLUDE_ICameraInfoParameterState)
    /// <summary>
    /// Stores an instance of the ICameraInfoParameterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ICameraInfoParameterState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ICameraInfoParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.ICameraInfoParameterType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIACAQAAAAEAIAAA" +
           "AElDYW1lcmFJbmZvUGFyYW1ldGVyVHlwZUluc3RhbmNlAQGZOgEBmTqZOgAAAf////8BAAAABGCACgEA" +
           "AAACAAwAAABQYXJhbWV0ZXJTZXQBAZo6AC8AOpo6AAD/////AgAAADdgiQoCAAAAAQAWAAAARGlzdG9y" +
           "dGlvbkNvZWZmaWNpZW50cwEBmzoDAAAAADUAAABDYW1lcmEgRGlzdG9ydGlvbiBDb2VmZmljaWVudHMg" +
           "PSBbazEsIGsyLCBwMSwgcDIsIGszXQAvAD+bOgAAAAsBAAAAAQAAAAMAAAADA/////8AAAAAN2CJCgIA" +
           "AAABAAwAAABDYW1lcmFNYXRyaXgBAZw6AwAAAAAvAAAAQ2FtZXJhIE1hdHJpeCA9IFsoZngsMCxjeCks" +
           "ICgwLGZ5LGN5KSwgKDAsMCwxKV0ALwA/nDoAAAALAQAAAAIAAAADAAAAAwAAAAMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ICameraFrameState Class
    #if (!OPCUA_EXCLUDE_ICameraFrameState)
    /// <summary>
    /// Stores an instance of the ICameraFrameType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ICameraFrameState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ICameraFrameState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.ICameraFrameType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIACAQAAAAEAGAAA" +
           "AElDYW1lcmFGcmFtZVR5cGVJbnN0YW5jZQEBQzwBAUM8QzwAAAH/////BgAAACRggAoBAAAAAQAGAAAA" +
           "SGVhZGVyAQFEPAMAAAAANQAAAFN0YW5kYXJkIG1ldGFkYXRhIGZvciBoaWdoZXItbGV2ZWwgc3RhbXBl" +
           "ZCBkYXRhIHR5cGVzAC8AOkQ8AAD/////AwAAADVgiQoCAAAAAQAKAAAAU2VxdWVuY2VJRAEBRTwDAAAA" +
           "ACEAAABDb25zZWN1dGl2ZWx5IGluY3JlYXNpbmcgZnJhbWUgSUQALwA/RTwAAAAH/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEABQAAAFN0YW1wAQFGPAMAAAAAFAAAAExhc3QgZnJhbWUgdGltZXN0YW1wAC8AP0Y8" +
           "AAAADf////8BAf////8AAAAANWCJCgIAAAABAAcAAABGcmFtZUlEAQFHPAMAAAAANAAAAENvb3JkaW5h" +
           "dGUgZnJhbWUgd2hpY2ggdGhlIGNhbWVyYSBpcyBhc3NvY2lhdGVkIHdpdGgALwA/RzwAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEABAAAAERhdGEBAUg8AwAAAABEAAAATGFzdCBmcmFtZSBieXRlIHN0cmlu" +
           "Zy4gRW5jb2RlZCBhcyBjb25maWd1cmVkLiBTaXplIGlzIChzdGVwICogcm93cykALwA/SDwAAAEA0Af/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAEAAAAU3RlcAEBSTwDAAAAAB4AAABGcmFtZSBmdWxsIHJvdyBs" +
           "ZW5ndGggaW4gYnl0ZXMALwA/STwAAAAH/////wMD/////wAAAAA1YIkKAgAAAAEACAAAAEVuY29kaW5n" +
           "AQFKPAMAAAAAOAAAAENhbWVyYSBmcmFtZSBlbmNvZGluZyB0eXBlLiBNaW5kIHRoZSBzdXBwb3J0ZWQg" +
           "ZW5jb2RpbmdzAC8AP0o8AAAADP////8DA/////8AAAAANWCJCgIAAAABAAYAAABIZWlnaHQBAUs8AwAA" +
           "AAAWAAAARnJhbWUgaGVpZ2h0IGluIHBpeGVscwAvAD9LPAAAAAf/////AwP/////AAAAADVgiQoCAAAA" +
           "AQAFAAAAV2lkdGgBAUw8AwAAAAAVAAAARnJhbWUgd2lkdGggaW4gcGl4ZWxzAC8AP0w8AAAAB/////8D" +
           "A/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState Header
        {
            get
            {
                return m_header;
            }

            set
            {
                if (!Object.ReferenceEquals(m_header, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_header = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<byte[]> Data
        {
            get
            {
                return m_data;
            }

            set
            {
                if (!Object.ReferenceEquals(m_data, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_data = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Step
        {
            get
            {
                return m_step;
            }

            set
            {
                if (!Object.ReferenceEquals(m_step, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_step = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Encoding
        {
            get
            {
                return m_encoding;
            }

            set
            {
                if (!Object.ReferenceEquals(m_encoding, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_encoding = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Height
        {
            get
            {
                return m_height;
            }

            set
            {
                if (!Object.ReferenceEquals(m_height, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_height = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Width
        {
            get
            {
                return m_width;
            }

            set
            {
                if (!Object.ReferenceEquals(m_width, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_width = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_header != null)
            {
                children.Add(m_header);
            }

            if (m_data != null)
            {
                children.Add(m_data);
            }

            if (m_step != null)
            {
                children.Add(m_step);
            }

            if (m_encoding != null)
            {
                children.Add(m_encoding);
            }

            if (m_height != null)
            {
                children.Add(m_height);
            }

            if (m_width != null)
            {
                children.Add(m_width);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Camera.BrowseNames.Header:
                {
                    if (createOrReplace)
                    {
                        if (Header == null)
                        {
                            if (replacement == null)
                            {
                                Header = new BaseObjectState(this);
                            }
                            else
                            {
                                Header = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Header;
                    break;
                }

                case Camera.BrowseNames.Data:
                {
                    if (createOrReplace)
                    {
                        if (Data == null)
                        {
                            if (replacement == null)
                            {
                                Data = new BaseDataVariableState<byte[]>(this);
                            }
                            else
                            {
                                Data = (BaseDataVariableState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = Data;
                    break;
                }

                case Camera.BrowseNames.Step:
                {
                    if (createOrReplace)
                    {
                        if (Step == null)
                        {
                            if (replacement == null)
                            {
                                Step = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Step = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Step;
                    break;
                }

                case Camera.BrowseNames.Encoding:
                {
                    if (createOrReplace)
                    {
                        if (Encoding == null)
                        {
                            if (replacement == null)
                            {
                                Encoding = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Encoding = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Encoding;
                    break;
                }

                case Camera.BrowseNames.Height:
                {
                    if (createOrReplace)
                    {
                        if (Height == null)
                        {
                            if (replacement == null)
                            {
                                Height = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Height = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Height;
                    break;
                }

                case Camera.BrowseNames.Width:
                {
                    if (createOrReplace)
                    {
                        if (Width == null)
                        {
                            if (replacement == null)
                            {
                                Width = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Width = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Width;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_header;
        private BaseDataVariableState<byte[]> m_data;
        private BaseDataVariableState<uint> m_step;
        private BaseDataVariableState<string> m_encoding;
        private BaseDataVariableState<uint> m_height;
        private BaseDataVariableState<uint> m_width;
        #endregion
    }
    #endif
    #endregion

    #region ImageSkillState Class
    #if (!OPCUA_EXCLUDE_ImageSkillState)
    /// <summary>
    /// Stores an instance of the ImageSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ImageSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ImageSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.ImageSkillType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIACAQAAAAEAFgAA" +
           "AEltYWdlU2tpbGxUeXBlSW5zdGFuY2UBAZ06AQGdOp06AAAB/////wsAAAAVYIkKAgAAAAAADAAAAEN1" +
           "cnJlbnRTdGF0ZQEBnjoALwEAyAqeOgAAABX/////AQH/////AgAAABVgiQoCAAAAAAACAAAASWQBAZ86" +
           "AC4ARJ86AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAaE6AC4ARKE6AAAAB///" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlvbgEBozoALwEAzwqjOgAAABX/////" +
           "AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAaQ6AC4ARKQ6AAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAYAAABOdW1iZXIBAaY6AC4ARKY6AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFu" +
           "c2l0aW9uVGltZQEBpzoALgBEpzoAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRh" +
           "YmxlAQGsOgAuAESsOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQEBrToA" +
           "LgBErToAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJlY3ljbGVDb3VudAEBrjoALgBErjoA" +
           "AAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1heEluc3RhbmNlQ291bnQBAbA6AC4ARLA6AAAA" +
           "B/////8BAf////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEB2joALwEAegnaOgAAAQEBAAAAADUBAQHK" +
           "OgAAAAAEYYIKBAAAAAAABwAAAFN1c3BlbmQBAds6AC8BAHsJ2zoAAAEBAQAAAAA1AQEB0DoAAAAABGGC" +
           "CgQAAAAAAAYAAABSZXN1bWUBAdw6AC8BAHwJ3DoAAAEBAQAAAAA1AQEB0joAAAAABGGCCgQAAAAAAAQA" +
           "AABIYWx0AQHdOgAvAQB9Cd06AAABAQMAAAAANQEBAcw6ADUBAQHUOgA1AQEB2DoAAAAABGGCCgQAAAAA" +
           "AAUAAABSZXNldAEB3joALwEAfgneOgAAAQEBAAAAADUBAQHIOgAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ImageStreamSkillState Class
    #if (!OPCUA_EXCLUDE_ImageStreamSkillState)
    /// <summary>
    /// Stores an instance of the ImageStreamSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ImageStreamSkillState : ImageSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ImageStreamSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.ImageStreamSkillType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIACAQAAAAEAHAAA" +
           "AEltYWdlU3RyZWFtU2tpbGxUeXBlSW5zdGFuY2UBAeA6AQHgOuA6AAAB/////wwAAAAVYIkKAgAAAAAA" +
           "DAAAAEN1cnJlbnRTdGF0ZQEB4ToALwEAyArhOgAAABX/////AQH/////AgAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAeI6AC4AROI6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAeQ6AC4AROQ6" +
           "AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlvbgEB5joALwEAzwrmOgAA" +
           "ABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAec6AC4AROc6AAAAEf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAYAAABOdW1iZXIBAek6AC4AROk6AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4A" +
           "AABUcmFuc2l0aW9uVGltZQEB6joALgBE6joAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RGVsZXRhYmxlAQHvOgAuAETvOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0" +
           "ZQEB8DoALgBE8DoAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJlY3ljbGVDb3VudAEB8ToA" +
           "LgBE8ToAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1heEluc3RhbmNlQ291bnQBAfM6AC4A" +
           "RPM6AAAAB/////8BAf////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEBHTsALwEAegkdOwAAAQEBAAAA" +
           "ADUBAQENOwAAAAAEYYIKBAAAAAAABwAAAFN1c3BlbmQBAR47AC8BAHsJHjsAAAEBAQAAAAA1AQEBEzsA" +
           "AAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAR87AC8BAHwJHzsAAAEBAQAAAAA1AQEBFTsAAAAABGGCCgQA" +
           "AAAAAAQAAABIYWx0AQEgOwAvAQB9CSA7AAABAQMAAAAANQEBAQ87ADUBAQEXOwA1AQEBGzsAAAAABGGC" +
           "CgQAAAAAAAUAAABSZXNldAEBITsALwEAfgkhOwAAAQEBAAAAADUBAQELOwAAAAAEYIAKAQAAAAIADAAA" +
           "AFBhcmFtZXRlclNldAEBIzsALwA6IzsAAP////8BAAAANWCpCgIAAAABAAMAAABGUFMBASQ7AwAAAAAR" +
           "AAAAQ2FtZXJhIFN0cmVhbSBGUFMALwA/JDsAAAUbAAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ImageFrameSkillState Class
    #if (!OPCUA_EXCLUDE_ImageFrameSkillState)
    /// <summary>
    /// Stores an instance of the ImageFrameSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ImageFrameSkillState : ImageSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ImageFrameSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.ImageFrameSkillType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIACAQAAAAEAGwAA" +
           "AEltYWdlRnJhbWVTa2lsbFR5cGVJbnN0YW5jZQEBJTsBASU7JTsAAAH/////DAAAABVgiQoCAAAAAAAM" +
           "AAAAQ3VycmVudFN0YXRlAQEmOwAvAQDICiY7AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBJzsALgBEJzsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBKTsALgBEKTsA" +
           "AAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQErOwAvAQDPCis7AAAA" +
           "Ff////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBLDsALgBELDsAAAAR/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABgAAAE51bWJlcgEBLjsALgBELjsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAA" +
           "AFRyYW5zaXRpb25UaW1lAQEvOwAuAEQvOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABE" +
           "ZWxldGFibGUBATQ7AC4ARDQ7AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRl" +
           "AQE1OwAuAEQ1OwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQE2OwAu" +
           "AEQ2OwAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBODsALgBE" +
           "ODsAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQFiOwAvAQB6CWI7AAABAQEAAAAA" +
           "NQEBAVI7AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEBYzsALwEAewljOwAAAQEBAAAAADUBAQFYOwAA" +
           "AAAEYYIKBAAAAAAABgAAAFJlc3VtZQEBZDsALwEAfAlkOwAAAQEBAAAAADUBAQFaOwAAAAAEYYIKBAAA" +
           "AAAABAAAAEhhbHQBAWU7AC8BAH0JZTsAAAEBAwAAAAA1AQEBVDsANQEBAVw7ADUBAQFgOwAAAAAEYYIK" +
           "BAAAAAAABQAAAFJlc2V0AQFmOwAvAQB+CWY7AAABAQEAAAAANQEBAVA7AAAAAARggAoBAAAAAgAMAAAA" +
           "UGFyYW1ldGVyU2V0AQFoOwAvADpoOwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region CameraDeviceState Class
    #if (!OPCUA_EXCLUDE_CameraDeviceState)
    /// <summary>
    /// Stores an instance of the CameraDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CameraDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CameraDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.CameraDeviceType, Camera.Namespaces.Camera, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////8EYIACAQAAAAEAGAAA" +
           "AENhbWVyYURldmljZVR5cGVJbnN0YW5jZQEBaTsBAWk7aTsAAP////8IAAAANWCJCgIAAAACAAwAAABN" +
           "YW51ZmFjdHVyZXIBAYA7AwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJl" +
           "ZCB0aGUgZGV2aWNlAC4ARIA7AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBgjsD" +
           "AAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEgjsAAAAV/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAYM7AwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhl" +
           "IGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEgzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AFNvZnR3YXJlUmV2aXNpb24BAYQ7AwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJl" +
           "L2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEhDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAA" +
           "AERldmljZVJldmlzaW9uAQGFOwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRl" +
           "dmljZQAuAESFOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGHOwMA" +
           "AAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBh" +
           "ZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAESHOwAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQGJOwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlx" +
           "dWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4A" +
           "RIk7AAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAYs7AwAAAABp" +
           "AAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhl" +
           "IHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARIs7AAAABv//" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}