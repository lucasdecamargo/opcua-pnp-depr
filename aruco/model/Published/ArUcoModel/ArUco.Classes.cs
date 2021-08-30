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

namespace ArUco
{
    #region MarkerDetectionSkillState Class
    #if (!OPCUA_EXCLUDE_MarkerDetectionSkillState)
    /// <summary>
    /// Stores an instance of the MarkerDetectionSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MarkerDetectionSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MarkerDetectionSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ArUco.ObjectTypes.MarkerDetectionSkillType, ArUco.Namespaces.ArUco, namespaceUris);
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
           "BAAAABkAAABodHRwczovL3BucC5vcmcvVUEvQXJVY28vHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9y" +
           "Zy9VQS9ESS8eAAAAaHR0cHM6Ly9mb3J0aXNzLm9yZy9VQS9EZXZpY2UvHAAAAGh0dHBzOi8vcG5wLm9y" +
           "Zy9VQS9QblBUeXBlcy//////hGCAAgEAAAABACAAAABNYXJrZXJEZXRlY3Rpb25Ta2lsbFR5cGVJbnN0" +
           "YW5jZQEBmToBAZk6mToAAAH/////DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGaOgAvAQDI" +
           "Cpo6AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBnToALgBEnToAAAAH/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADgAAAExhc3RUcmFuc2l0aW9uAQGfOgAvAQDPCp86AAAAFf////8BAf////8DAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBoDoALgBEoDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBojoA" +
           "LgBEojoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGjOgAuAESj" +
           "OgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4ARKg6AAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBrDoALgBErDoAAAAH/////wEB/////wAAAAAEYYIK" +
           "BAAAAAAABQAAAFN0YXJ0AQHWOgAvAQB6CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoEAAAAAAAHAAAA" +
           "U3VzcGVuZAEB1zoALwEAewnXOgAAAQEBAAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB" +
           "2DoALwEAfAnYOgAAAQEBAAAAADUBAQHOOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6AC8BAH0J2ToA" +
           "AAEBAwAAAAA1AQEByDoANQEBAdA6ADUBAQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHaOgAvAQB+" +
           "Cdo6AAABAQEAAAAANQEBAcQ6AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHcOgAvADrcOgAA" +
           "/////wQAAAA1YIkKAgAAAAEACgAAAElucHV0SW1hZ2UBAd06AwAAAAA0AAAAQ29udGFpbnMgdGhlIGRh" +
           "dGEgb2YgdGhlIGlucHV0IGltYWdlIHRvIGJlIHByb2Nlc3NlZAAvAD/dOgAAAQSbOv////8BAf////8A" +
           "AAAANWCJCgIAAAABAAsAAABPdXRwdXRJbWFnZQEB5zoDAAAAAFkAAABJZiBJbWFnZU91dHB1dCBwYXJh" +
           "bWV0ZXIgaXMgc2V0LCBjb250YWlucyB0aGUgZGF0YSBvZiB0aGUgb3V0cHV0IGltYWdlIHdpdGggZHJh" +
           "d24gbWFya2VycwAvAD/nOgAAAQSbOv////8BAf////8AAAAANWCpCgIAAAABAA4AAABQb3NlRXN0aW1h" +
           "dGlvbgEB8ToDAAAAADEAAABJZiB0cnVlLCBleGVjdXRlcyB0aGUgcG9zZSBlc3RpbWF0aW9uIGNhbGN1" +
           "bGF0aW9uAC8AP/E6AAABAAAB/////wMD/////wAAAAAVYIkKAgAAAAEACgAAAENhbWVyYUluZm8BAd46" +
           "AC8AP946AAABBM06/////wEB/////wAAAAA=";
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

    #region ArUcoComponentState Class
    #if (!OPCUA_EXCLUDE_ArUcoComponentState)
    /// <summary>
    /// Stores an instance of the ArUcoComponentType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ArUcoComponentState : SoftwareState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ArUcoComponentState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ArUco.ObjectTypes.ArUcoComponentType, ArUco.Namespaces.ArUco, namespaceUris);
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
           "BAAAABkAAABodHRwczovL3BucC5vcmcvVUEvQXJVY28vHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9y" +
           "Zy9VQS9ESS8eAAAAaHR0cHM6Ly9mb3J0aXNzLm9yZy9VQS9EZXZpY2UvHAAAAGh0dHBzOi8vcG5wLm9y" +
           "Zy9VQS9QblBUeXBlcy//////BGCAAgEAAAABABoAAABBclVjb0NvbXBvbmVudFR5cGVJbnN0YW5jZQEB" +
           "8joBAfI68joAAP////8DAAAAFWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAQk7AC4ARAk7AAAAFf//" +
           "//8BAf////8AAAAAFWCJCgIAAAACAAUAAABNb2RlbAEBCzsALgBECzsAAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAQ07AC4ARA07AAAADP////8BAf////8AAAAA";
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