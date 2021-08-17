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

namespace CompositeSkills
{
    #region RTMarkerDetectionSkillState Class
    #if (!OPCUA_EXCLUDE_RTMarkerDetectionSkillState)
    /// <summary>
    /// Stores an instance of the RTMarkerDetectionSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RTMarkerDetectionSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RTMarkerDetectionSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(CompositeSkills.ObjectTypes.RTMarkerDetectionSkillType, CompositeSkills.Namespaces.CompositeSkills, namespaceUris);
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
           "AwAAACMAAABodHRwczovL3BucC5vcmcvVUEvQ29tcG9zaXRlU2tpbGxzLx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////+EYIAC" +
           "AQAAAAEAIgAAAFJUTWFya2VyRGV0ZWN0aW9uU2tpbGxUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAAB////" +
           "/w0AAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBmjoALwEAyAqaOgAAABX/////AQH/////AgAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAZs6AC4ARJs6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABO" +
           "dW1iZXIBAZ06AC4ARJ06AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlv" +
           "bgEBnzoALwEAzwqfOgAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAaA6AC4ARKA6AAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAaI6AC4ARKI6AAAAB/////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEBozoALgBEozoAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQGoOgAuAESoOgAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAKAAAAQXV0b0RlbGV0ZQEBqToALgBEqToAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJl" +
           "Y3ljbGVDb3VudAEBqjoALgBEqjoAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1heEluc3Rh" +
           "bmNlQ291bnQBAaw6AC4ARKw6AAAAB/////8BAf////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEB1joA" +
           "LwEAegnWOgAAAQEBAAAAADUBAQHGOgAAAAAEYYIKBAAAAAAABwAAAFN1c3BlbmQBAdc6AC8BAHsJ1zoA" +
           "AAEBAQAAAAA1AQEBzDoAAAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAdg6AC8BAHwJ2DoAAAEBAQAAAAA1" +
           "AQEBzjoAAAAABGGCCgQAAAAAAAQAAABIYWx0AQHZOgAvAQB9Cdk6AAABAQMAAAAANQEBAcg6ADUBAQHQ" +
           "OgA1AQEB1DoAAAAABGGCCgQAAAAAAAUAAABSZXNldAEB2joALwEAfgnaOgAAAQEBAAAAADUBAQHEOgAA" +
           "AAA1YIkKAgAAAAEACQAAAFNraWxsU3RlcAEB3DoDAAAAAFkAAABUaGUgY3VycmVudCBleGVjdXRlZCBz" +
           "dGVwIHJlcHJlc2VudGVkIGFzIHN0cmluZy4gSS5lLiwgQ2FtZXJhQ2FwdHVyZSwgSW1hZ2VQcm9jZXNz" +
           "b3IsIC4uLgAvAD/cOgAAAAz/////AQH/////AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHd" +
           "OgAvADrdOgAA/////wIAAAA1YIkKAgAAAAEAHgAAAENhbWVyYVNraWxsQ29udHJvbGxlckVuZHBvaW50" +
           "cwEB3joDAAAAAEkAAABUaGUgZW5kcG9pbnRzIFVSTCBvZiB0aGUgY2FtZXJhIGNvbnRyb2xsZXJzIHRv" +
           "IGJlIHVzZWQgZm9yIGdldHRpbmcgaW1hZ2VzAC8AP946AAAADP////8BAf////8AAAAANWCJCgIAAAAB" +
           "ABYAAABJbWFnZVByb2Nlc3NvckVuZHBvaW50AQGWOwMAAAAARQAAAFRoZSBlbmRwb2ludCBVUkwgb2Yg" +
           "dGhlIGltYWdlIHByb2Nlc3NpbmcgbW9kdWxlcyBmb3IgaW1hZ2UgcHJvY2Vzc2luZwAvAD+WOwAAAAz/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> SkillStep
        {
            get
            {
                return m_skillStep;
            }

            set
            {
                if (!Object.ReferenceEquals(m_skillStep, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_skillStep = value;
            }
        }

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
            if (m_skillStep != null)
            {
                children.Add(m_skillStep);
            }

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
                case CompositeSkills.BrowseNames.SkillStep:
                {
                    if (createOrReplace)
                    {
                        if (SkillStep == null)
                        {
                            if (replacement == null)
                            {
                                SkillStep = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                SkillStep = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = SkillStep;
                    break;
                }

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
        private BaseDataVariableState<string> m_skillStep;
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region CompositeSkillsState Class
    #if (!OPCUA_EXCLUDE_CompositeSkillsState)
    /// <summary>
    /// Stores an instance of the CompositeSkillsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CompositeSkillsState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CompositeSkillsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(CompositeSkills.ObjectTypes.CompositeSkillsType, CompositeSkills.Namespaces.CompositeSkills, namespaceUris);
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
           "AwAAACMAAABodHRwczovL3BucC5vcmcvVUEvQ29tcG9zaXRlU2tpbGxzLx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////8EYIAC" +
           "AQAAAAEAGwAAAENvbXBvc2l0ZVNraWxsc1R5cGVJbnN0YW5jZQEB4DoBAeA64DoAAP////8IAAAANWCJ" +
           "CgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAfc6AwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0" +
           "IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARPc6AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUA" +
           "AABNb2RlbAEB+ToDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBE+ToAAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAfo6AwAAAAAsAAAAUmV2aXNpb24g" +
           "bGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE+joAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAfs6AwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE+zoAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQH8OgMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIGRldmljZQAuAET8OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNl" +
           "TWFudWFsAQH+OgMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBh" +
           "IFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAET+OgAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEAOwMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARAA7AAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBAQI7AwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4ARAI7AAAABv////8BAf////8AAAAA";
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