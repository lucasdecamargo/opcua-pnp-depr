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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;
using PnPTypes;

namespace ArUco
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock Method.
        /// </summary>
        public const uint ArUcoComponentType_Lock_InitLock = 15104;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RenewLock Method.
        /// </summary>
        public const uint ArUcoComponentType_Lock_RenewLock = 15107;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_ExitLock Method.
        /// </summary>
        public const uint ArUcoComponentType_Lock_ExitLock = 15109;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_BreakLock Method.
        /// </summary>
        public const uint ArUcoComponentType_Lock_BreakLock = 15111;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock Method.
        /// </summary>
        public const uint ArUcoComponent_Lock_InitLock = 15141;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RenewLock Method.
        /// </summary>
        public const uint ArUcoComponent_Lock_RenewLock = 15144;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_ExitLock Method.
        /// </summary>
        public const uint ArUcoComponent_Lock_ExitLock = 15146;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_BreakLock Method.
        /// </summary>
        public const uint ArUcoComponent_Lock_BreakLock = 15148;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Halt Method.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Halt = 15197;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Reset Method.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Reset = 15198;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Resume Method.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Resume = 15199;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Suspend Method.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Suspend = 15200;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Start Method.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Start = 15201;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the ArUcoComponent Object.
        /// </summary>
        public const uint ArUcoComponent = 15127;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills Object.
        /// </summary>
        public const uint ArUcoComponent_Skills = 15164;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill Object.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill = 15165;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet = 15202;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType ObjectType.
        /// </summary>
        public const uint MarkerDetectionSkillType = 15001;

        /// <summary>
        /// The identifier for the ArUcoComponentType ObjectType.
        /// </summary>
        public const uint ArUcoComponentType = 15090;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_InputImage Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_InputImage = 15069;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_OutputImage Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_OutputImage = 15079;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_PoseEstimation Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_PoseEstimation = 15089;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_CameraInfo Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_CameraInfo = 15070;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_Locked Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_Locked = 15100;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_LockingClient = 15101;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_LockingUser = 15102;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_RemainingLockTime = 15103;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_InitLock_InputArguments = 15105;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_InitLock_OutputArguments = 15106;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_RenewLock_OutputArguments = 15108;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_ExitLock_OutputArguments = 15110;

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponentType_Lock_BreakLock_OutputArguments = 15112;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_Locked Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_Locked = 15137;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_LockingClient Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_LockingClient = 15138;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_LockingUser Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_LockingUser = 15139;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_RemainingLockTime = 15140;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_InitLock_InputArguments = 15142;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_InitLock_OutputArguments = 15143;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_RenewLock_OutputArguments = 15145;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_ExitLock_OutputArguments = 15147;

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Lock_BreakLock_OutputArguments = 15149;

        /// <summary>
        /// The identifier for the ArUcoComponent_Manufacturer Variable.
        /// </summary>
        public const uint ArUcoComponent_Manufacturer = 15150;

        /// <summary>
        /// The identifier for the ArUcoComponent_Model Variable.
        /// </summary>
        public const uint ArUcoComponent_Model = 15152;

        /// <summary>
        /// The identifier for the ArUcoComponent_SoftwareRevision Variable.
        /// </summary>
        public const uint ArUcoComponent_SoftwareRevision = 15154;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState = 15166;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Id = 15167;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Number = 15169;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition = 15171;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Id = 15172;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Number = 15174;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_TransitionTime = 15175;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_Deletable = 15179;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_AutoDelete = 15180;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_RecycleCount = 15181;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = 15183;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName = 15184;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = 15185;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = 15186;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = 15187;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = 15188;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = 15189;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = 15190;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = 15191;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = 15192;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = 15193;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = 15194;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_MaxInstanceCount = 15196;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_InputImage Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_InputImage = 15203;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_OutputImage Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_OutputImage = 15204;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_PoseEstimation Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_PoseEstimation = 15205;

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo Variable.
        /// </summary>
        public const uint ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo = 15071;

        /// <summary>
        /// The identifier for the ArUcoComponent_MarkerArray Variable.
        /// </summary>
        public const uint ArUcoComponent_MarkerArray = 15206;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_InitLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponentType_Lock_InitLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_RenewLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponentType_Lock_RenewLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_ExitLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponentType_Lock_ExitLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_BreakLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponentType_Lock_BreakLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_InitLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Lock_InitLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_RenewLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Lock_RenewLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_ExitLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Lock_ExitLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_BreakLock = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Lock_BreakLock, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Halt = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Skills_MarkerDetectionSkill_Halt, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Reset = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Skills_MarkerDetectionSkill_Reset, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Resume = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Skills_MarkerDetectionSkill_Resume, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Suspend = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Skills_MarkerDetectionSkill_Suspend, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Start = new ExpandedNodeId(ArUco.Methods.ArUcoComponent_Skills_MarkerDetectionSkill_Start, ArUco.Namespaces.ArUco);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet = new ExpandedNodeId(ArUco.Objects.MarkerDetectionSkillType_ParameterSet, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent Object.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent = new ExpandedNodeId(ArUco.Objects.ArUcoComponent, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills = new ExpandedNodeId(ArUco.Objects.ArUcoComponent_Skills, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill = new ExpandedNodeId(ArUco.Objects.ArUcoComponent_Skills_MarkerDetectionSkill, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet = new ExpandedNodeId(ArUco.Objects.ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet, ArUco.Namespaces.ArUco);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType = new ExpandedNodeId(ArUco.ObjectTypes.MarkerDetectionSkillType, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType = new ExpandedNodeId(ArUco.ObjectTypes.ArUcoComponentType, ArUco.Namespaces.ArUco);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_CurrentState_Id = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_CurrentState_Id, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_CurrentState_Number = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_CurrentState_Number, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_Id = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_LastTransition_Id, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_Number = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_LastTransition_Number, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_TransitionTime = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_LastTransition_TransitionTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Halted_StateNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_Halted_StateNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Ready_StateNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_Ready_StateNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Running_StateNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_Running_StateNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Suspended_StateNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_Suspended_StateNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_HaltedToReady_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ReadyToRunning_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_RunningToHalted_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_RunningToReady_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_RunningToSuspended_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_SuspendedToReady_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ReadyToHalted_TransitionNumber, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_InputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_InputImage = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ParameterSet_InputImage, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_OutputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_OutputImage = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ParameterSet_OutputImage, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_PoseEstimation Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_PoseEstimation = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ParameterSet_PoseEstimation, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_CameraInfo = new ExpandedNodeId(ArUco.Variables.MarkerDetectionSkillType_ParameterSet_CameraInfo, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_Locked = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_Locked, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_LockingClient = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_LockingClient, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_LockingUser = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_LockingUser, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_RemainingLockTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_RemainingLockTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_InitLock_InputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_InitLock_InputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_InitLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_InitLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_RenewLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_ExitLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponentType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponentType_Lock_BreakLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_Locked = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_Locked, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_LockingClient = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_LockingClient, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_LockingUser = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_LockingUser, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_RemainingLockTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_RemainingLockTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_InitLock_InputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_InitLock_InputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_InitLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_InitLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_RenewLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_ExitLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Lock_BreakLock_OutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Manufacturer = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Manufacturer, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Model = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Model, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_SoftwareRevision = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_SoftwareRevision, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Id = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Id, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Number = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_CurrentState_Number, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Id = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Id, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Number = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_Number, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_TransitionTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_LastTransition_TransitionTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_Deletable = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_Deletable, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_AutoDelete = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_AutoDelete, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_RecycleCount = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_RecycleCount, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_MaxInstanceCount = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_MaxInstanceCount, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_InputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_InputImage = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_InputImage, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_OutputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_OutputImage = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_OutputImage, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_PoseEstimation Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_PoseEstimation = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_PoseEstimation, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo, ArUco.Namespaces.ArUco);

        /// <summary>
        /// The identifier for the ArUcoComponent_MarkerArray Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArUcoComponent_MarkerArray = new ExpandedNodeId(ArUco.Variables.ArUcoComponent_MarkerArray, ArUco.Namespaces.ArUco);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ArUcoComponent component.
        /// </summary>
        public const string ArUcoComponent = "ArUcoComponent";

        /// <summary>
        /// The BrowseName for the ArUcoComponentType component.
        /// </summary>
        public const string ArUcoComponentType = "ArUcoComponentType";

        /// <summary>
        /// The BrowseName for the MarkerArray component.
        /// </summary>
        public const string MarkerArray = "MarkerArray";

        /// <summary>
        /// The BrowseName for the MarkerDetectionSkillType component.
        /// </summary>
        public const string MarkerDetectionSkillType = "MarkerDetectionSkillType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ArUco namespace (.NET code namespace is 'ArUco').
        /// </summary>
        public const string ArUco = "https://pnp.org/UA/ArUco/";

        /// <summary>
        /// The URI for the ArUcoXsd namespace (.NET code namespace is 'ArUco').
        /// </summary>
        public const string ArUcoXsd = "https://pnp.org/UA/ArUco/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";

        /// <summary>
        /// The URI for the PnPTypes namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypes = "https://pnp.org/UA/PnPTypes/";

        /// <summary>
        /// The URI for the PnPTypesXsd namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypesXsd = "https://pnp.org/UA/PnPTypes/Types.xsd";
    }
    #endregion
}