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

namespace CompositeSkills
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
        /// The identifier for the CompositeSkillsType_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock = 15086;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RenewLock = 15089;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_ExitLock = 15091;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_BreakLock = 15093;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock = 15121;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RenewLock = 15124;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_ExitLock = 15126;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_BreakLock = 15128;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock = 15156;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_RenewLock = 15159;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_ExitLock = 15161;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_BreakLock = 15163;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock = 15191;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RenewLock = 15194;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_ExitLock = 15196;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_BreakLock = 15198;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Halt Method.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Halt = 15245;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Reset Method.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Reset = 15246;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Resume Method.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Resume = 15247;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Suspend Method.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Suspend = 15248;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Start Method.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Start = 15249;
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
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ParameterSet = 15069;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_NetworkAddress = 15130;

        /// <summary>
        /// The identifier for the CompositeSkills Object.
        /// </summary>
        public const uint CompositeSkills = 15142;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_NetworkAddress = 15200;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills Object.
        /// </summary>
        public const uint CompositeSkills_Skills = 15212;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill Object.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill = 15213;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet = 15251;
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
        /// The identifier for the RTMarkerDetectionSkillType ObjectType.
        /// </summary>
        public const uint RTMarkerDetectionSkillType = 15001;

        /// <summary>
        /// The identifier for the CompositeSkillsType ObjectType.
        /// </summary>
        public const uint CompositeSkillsType = 15072;
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
        /// The identifier for the RTMarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SkillStep Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_SkillStep = 15068;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet_CameraSkillControllerEndpoints Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ParameterSet_CameraSkillControllerEndpoints = 15070;

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet_ImageProcessorEndpoint Variable.
        /// </summary>
        public const uint RTMarkerDetectionSkillType_ParameterSet_ImageProcessorEndpoint = 15254;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_Locked = 15082;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_LockingClient = 15083;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_LockingUser = 15084;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RemainingLockTime = 15085;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock_InputArguments = 15087;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock_OutputArguments = 15088;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RenewLock_OutputArguments = 15090;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_ExitLock_OutputArguments = 15092;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_BreakLock_OutputArguments = 15094;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_Locked = 15117;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_LockingClient = 15118;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_LockingUser = 15119;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime = 15120;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments = 15122;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments = 15123;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments = 15125;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments = 15127;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments = 15129;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_Locked = 15152;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_LockingClient = 15153;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_LockingUser = 15154;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_RemainingLockTime = 15155;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock_InputArguments = 15157;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock_OutputArguments = 15158;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_RenewLock_OutputArguments = 15160;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_ExitLock_OutputArguments = 15162;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_BreakLock_OutputArguments = 15164;

        /// <summary>
        /// The identifier for the CompositeSkills_Manufacturer Variable.
        /// </summary>
        public const uint CompositeSkills_Manufacturer = 15165;

        /// <summary>
        /// The identifier for the CompositeSkills_Model Variable.
        /// </summary>
        public const uint CompositeSkills_Model = 15167;

        /// <summary>
        /// The identifier for the CompositeSkills_HardwareRevision Variable.
        /// </summary>
        public const uint CompositeSkills_HardwareRevision = 15168;

        /// <summary>
        /// The identifier for the CompositeSkills_SoftwareRevision Variable.
        /// </summary>
        public const uint CompositeSkills_SoftwareRevision = 15169;

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceRevision Variable.
        /// </summary>
        public const uint CompositeSkills_DeviceRevision = 15170;

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceManual Variable.
        /// </summary>
        public const uint CompositeSkills_DeviceManual = 15172;

        /// <summary>
        /// The identifier for the CompositeSkills_SerialNumber Variable.
        /// </summary>
        public const uint CompositeSkills_SerialNumber = 15174;

        /// <summary>
        /// The identifier for the CompositeSkills_RevisionCounter Variable.
        /// </summary>
        public const uint CompositeSkills_RevisionCounter = 15176;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_Locked = 15187;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_LockingClient = 15188;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_LockingUser = 15189;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RemainingLockTime = 15190;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments = 15192;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments = 15193;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments = 15195;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments = 15197;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments = 15199;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState = 15214;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Id = 15215;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Number = 15217;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition = 15219;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Id = 15220;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Number = 15222;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_TransitionTime = 15223;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_Deletable = 15227;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_AutoDelete = 15228;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_RecycleCount = 15229;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = 15231;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateClientName = 15232;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = 15233;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = 15234;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = 15235;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = 15236;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = 15237;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = 15238;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = 15239;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = 15240;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = 15241;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = 15242;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_MaxInstanceCount = 15244;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_SkillStep Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_SkillStep = 15250;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_CameraSkillControllerEndpoints Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_CameraSkillControllerEndpoints = 15252;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_ImageProcessorEndpoint Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_ImageProcessorEndpoint = 15255;
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
        /// The identifier for the CompositeSkillsType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Halt = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_RTMarkerDetectionSkill_Halt, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Reset = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_RTMarkerDetectionSkill_Reset, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Resume = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_RTMarkerDetectionSkill_Resume, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Suspend = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_RTMarkerDetectionSkill_Suspend, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Start = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_RTMarkerDetectionSkill_Start, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ParameterSet = new ExpandedNodeId(CompositeSkills.Objects.RTMarkerDetectionSkillType_ParameterSet, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_NetworkAddress = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkillsType_CPIdentifier_NetworkAddress, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_NetworkAddress = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_CPIdentifier_NetworkAddress, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills_RTMarkerDetectionSkill, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the RTMarkerDetectionSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType = new ExpandedNodeId(CompositeSkills.ObjectTypes.RTMarkerDetectionSkillType, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType = new ExpandedNodeId(CompositeSkills.ObjectTypes.CompositeSkillsType, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the RTMarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_CurrentState_Id = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_CurrentState_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_CurrentState_Number = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_CurrentState_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_LastTransition_Id = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_LastTransition_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_LastTransition_Number = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_LastTransition_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_LastTransition_TransitionTime = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_LastTransition_TransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_CreateClientName, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_Halted_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_Halted_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_Ready_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_Ready_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_Running_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_Running_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_Suspended_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_Suspended_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_HaltedToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ReadyToRunning_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_RunningToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_RunningToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_RunningToSuspended_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_SuspendedToRunning_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_SuspendedToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_SuspendedToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ReadyToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_SkillStep Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_SkillStep = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_SkillStep, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet_CameraSkillControllerEndpoints Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ParameterSet_CameraSkillControllerEndpoints = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ParameterSet_CameraSkillControllerEndpoints, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the RTMarkerDetectionSkillType_ParameterSet_ImageProcessorEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId RTMarkerDetectionSkillType_ParameterSet_ImageProcessorEndpoint = new ExpandedNodeId(CompositeSkills.Variables.RTMarkerDetectionSkillType_ParameterSet_ImageProcessorEndpoint, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Manufacturer = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Manufacturer, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Model = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Model, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_HardwareRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_HardwareRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_SoftwareRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_SoftwareRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_DeviceRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_DeviceRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_DeviceManual = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_DeviceManual, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_SerialNumber = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_SerialNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_RevisionCounter = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_RevisionCounter, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Id = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Number = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_CurrentState_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Id = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Number = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_TransitionTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_LastTransition_TransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_Deletable = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_Deletable, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_AutoDelete = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_AutoDelete, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_RecycleCount = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_RecycleCount, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_CreateClientName, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCall, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_MaxInstanceCount = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_MaxInstanceCount, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_SkillStep Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_SkillStep = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_SkillStep, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_CameraSkillControllerEndpoints Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_CameraSkillControllerEndpoints = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_CameraSkillControllerEndpoints, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_ImageProcessorEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_ImageProcessorEndpoint = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_RTMarkerDetectionSkill_ParameterSet_ImageProcessorEndpoint, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The BrowseName for the CompositeSkills component.
        /// </summary>
        public const string CompositeSkills = "CompositeSkills";

        /// <summary>
        /// The BrowseName for the CompositeSkillsType component.
        /// </summary>
        public const string CompositeSkillsType = "CompositeSkillsType";

        /// <summary>
        /// The BrowseName for the RTMarkerDetectionSkillType component.
        /// </summary>
        public const string RTMarkerDetectionSkillType = "RTMarkerDetectionSkill";

        /// <summary>
        /// The BrowseName for the SkillStep component.
        /// </summary>
        public const string SkillStep = "SkillStep";
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
        /// The URI for the CompositeSkills namespace (.NET code namespace is 'CompositeSkills').
        /// </summary>
        public const string CompositeSkills = "https://pnp.org/UA/CompositeSkills/";

        /// <summary>
        /// The URI for the CompositeSkillsXsd namespace (.NET code namespace is 'CompositeSkills').
        /// </summary>
        public const string CompositeSkillsXsd = "https://pnp.org/UA/CompositeSkills/Types.xsd";

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
    }
    #endregion
}