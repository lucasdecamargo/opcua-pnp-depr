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
using PnPTypes;

namespace Camera
{
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////4RggAIBAAAAAQAWAAAASW1hZ2VTa2lsbFR5cGVJbnN0YW5jZQEBnToB" +
           "AZ06nToAAAH/////CwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGeOgAvAQDICp46AAAAFf//" +
           "//8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBnzoALgBEnzoAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAE51bWJlcgEBoToALgBEoToAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExh" +
           "c3RUcmFuc2l0aW9uAQGjOgAvAQDPCqM6AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "pDoALgBEpDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBpjoALgBEpjoAAAAH" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGnOgAuAESnOgAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAaw6AC4ARKw6AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQGtOgAuAEStOgAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAAUmVjeWNsZUNvdW50AQGuOgAuAESuOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAATWF4SW5zdGFuY2VDb3VudAEBsDoALgBEsDoAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAA" +
           "AFN0YXJ0AQHaOgAvAQB6Cdo6AAABAQEAAAAANQEBAco6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEB" +
           "2zoALwEAewnbOgAAAQEBAAAAADUBAQHQOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB3DoALwEAfAnc" +
           "OgAAAQEBAAAAADUBAQHSOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAd06AC8BAH0J3ToAAAEBAwAAAAA1" +
           "AQEBzDoANQEBAdQ6ADUBAQHYOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHeOgAvAQB+Cd46AAABAQEA" +
           "AAAANQEBAcg6AAAAAA==";
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////4RggAIBAAAAAQAcAAAASW1hZ2VTdHJlYW1Ta2lsbFR5cGVJbnN0YW5j" +
           "ZQEB4DoBAeA64DoAAAH/////DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQHhOgAvAQDICuE6" +
           "AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEB4joALgBE4joAAAAR/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABgAAAE51bWJlcgEB5DoALgBE5DoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DgAAAExhc3RUcmFuc2l0aW9uAQHmOgAvAQDPCuY6AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIA" +
           "AABJZAEB5zoALgBE5zoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEB6ToALgBE" +
           "6ToAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQHqOgAuAETqOgAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAe86AC4ARO86AAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQHwOgAuAETwOgAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQHxOgAuAETxOgAAAAb/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEB8zoALgBE8zoAAAAH/////wEB/////wAAAAAEYYIKBAAA" +
           "AAAABQAAAFN0YXJ0AQEdOwAvAQB6CR07AAABAQEAAAAANQEBAQ07AAAAAARhggoEAAAAAAAHAAAAU3Vz" +
           "cGVuZAEBHjsALwEAewkeOwAAAQEBAAAAADUBAQETOwAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEBHzsA" +
           "LwEAfAkfOwAAAQEBAAAAADUBAQEVOwAAAAAEYYIKBAAAAAAABAAAAEhhbHQBASA7AC8BAH0JIDsAAAEB" +
           "AwAAAAA1AQEBDzsANQEBARc7ADUBAQEbOwAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQEhOwAvAQB+CSE7" +
           "AAABAQEAAAAANQEBAQs7AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQEjOwAvADojOwAA////" +
           "/wEAAAA1YKkKAgAAAAEAAwAAAEZQUwEBJDsDAAAAABEAAABDYW1lcmEgU3RyZWFtIEZQUwAvAD8kOwAA" +
           "BRsAAAX/////AwP/////AAAAAA==";
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////4RggAIBAAAAAQAbAAAASW1hZ2VGcmFtZVNraWxsVHlwZUluc3RhbmNl" +
           "AQElOwEBJTslOwAAAf////8MAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBASY7AC8BAMgKJjsA" +
           "AAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQEnOwAuAEQnOwAAABH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAGAAAATnVtYmVyAQEpOwAuAEQpOwAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAO" +
           "AAAATGFzdFRyYW5zaXRpb24BASs7AC8BAM8KKzsAAAAV/////wEB/////wMAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQEsOwAuAEQsOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQEuOwAuAEQu" +
           "OwAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAS87AC4ARC87AAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAERlbGV0YWJsZQEBNDsALgBENDsAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACgAAAEF1dG9EZWxldGUBATU7AC4ARDU7AAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABSZWN5Y2xlQ291bnQBATY7AC4ARDY7AAAABv////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABAAAABNYXhJbnN0YW5jZUNvdW50AQE4OwAuAEQ4OwAAAAf/////AQH/////AAAAAARhggoEAAAA" +
           "AAAFAAAAU3RhcnQBAWI7AC8BAHoJYjsAAAEBAQAAAAA1AQEBUjsAAAAABGGCCgQAAAAAAAcAAABTdXNw" +
           "ZW5kAQFjOwAvAQB7CWM7AAABAQEAAAAANQEBAVg7AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQFkOwAv" +
           "AQB8CWQ7AAABAQEAAAAANQEBAVo7AAAAAARhggoEAAAAAAAEAAAASGFsdAEBZTsALwEAfQllOwAAAQED" +
           "AAAAADUBAQFUOwA1AQEBXDsANQEBAWA7AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAWY7AC8BAH4JZjsA" +
           "AAEBAQAAAAA1AQEBUDsAAAAABGCACgEAAAACAAwAAABQYXJhbWV0ZXJTZXQBAWg7AC8AOmg7AAD/////" +
           "AAAAAA==";
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////wRggAIBAAAAAQAYAAAAQ2FtZXJhRGV2aWNlVHlwZUluc3RhbmNlAQFp" +
           "OwEBaTtpOwAA/////wgAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBgDsDAAAAADAAAABOYW1l" +
           "IG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEgDsAAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQGCOwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRl" +
           "dmljZQAuAESCOwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB" +
           "gzsDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAESD" +
           "OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBhDsDAAAAADUA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAESE" +
           "OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAYU7AwAAAAAkAAAA" +
           "T3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARIU7AAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAYc7AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4g" +
           "dGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0" +
           "aGUgZGV2aWNlAC4ARIc7AAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIB" +
           "AYk7AwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1h" +
           "bnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEiTsAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADwAAAFJldmlzaW9uQ291bnRlcgEBizsDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGlu" +
           "ZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZp" +
           "Y2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEizsAAAAG/////wEB/////wAAAAA=";
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