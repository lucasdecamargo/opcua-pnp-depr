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

namespace Camera
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
        /// The identifier for the CameraDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock = 15223;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_RenewLock = 15226;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_ExitLock = 15228;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_BreakLock = 15230;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock = 15258;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RenewLock = 15261;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_ExitLock = 15263;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_BreakLock = 15265;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock = 15293;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_RenewLock = 15296;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_ExitLock = 15298;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_BreakLock = 15300;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock = 15328;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RenewLock = 15331;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_ExitLock = 15333;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_BreakLock = 15335;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Halt Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Halt = 15382;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Reset Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Reset = 15383;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Resume Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Resume = 15384;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Suspend Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Suspend = 15385;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Start Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Start = 15386;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Halt Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Halt = 15421;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Reset Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Reset = 15422;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Resume Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Resume = 15423;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Suspend Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Suspend = 15424;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Start Method.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Start = 15425;
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
        /// The identifier for the ImageStreamSkillType_ParameterSet Object.
        /// </summary>
        public const uint ImageStreamSkillType_ParameterSet = 15139;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ParameterSet Object.
        /// </summary>
        public const uint ImageFrameSkillType_ParameterSet = 15208;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_NetworkAddress = 15267;

        /// <summary>
        /// The identifier for the CameraDevice Object.
        /// </summary>
        public const uint CameraDevice = 15279;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_NetworkAddress = 15337;

        /// <summary>
        /// The identifier for the CameraDevice_Skills Object.
        /// </summary>
        public const uint CameraDevice_Skills = 15349;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill Object.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill = 15350;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ParameterSet Object.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ParameterSet = 15387;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill Object.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill = 15389;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ParameterSet Object.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ParameterSet = 15426;
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
        /// The identifier for the ImageSkillType ObjectType.
        /// </summary>
        public const uint ImageSkillType = 15005;

        /// <summary>
        /// The identifier for the ImageStreamSkillType ObjectType.
        /// </summary>
        public const uint ImageStreamSkillType = 15072;

        /// <summary>
        /// The identifier for the ImageFrameSkillType ObjectType.
        /// </summary>
        public const uint ImageFrameSkillType = 15141;

        /// <summary>
        /// The identifier for the CameraDeviceType ObjectType.
        /// </summary>
        public const uint CameraDeviceType = 15209;
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
        /// The identifier for the ImageSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint ImageSkillType_CurrentState_Id = 15007;

        /// <summary>
        /// The identifier for the ImageSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint ImageSkillType_CurrentState_Number = 15009;

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint ImageSkillType_LastTransition_Id = 15012;

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint ImageSkillType_LastTransition_Number = 15014;

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ImageSkillType_LastTransition_TransitionTime = 15015;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_CreateSessionId = 15027;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_CreateClientName = 15028;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_InvocationCreationTime = 15029;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastTransitionTime = 15030;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodCall = 15031;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodSessionId = 15032;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodInputArguments = 15033;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15034;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodInputValues = 15035;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodOutputValues = 15036;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodCallTime = 15037;

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ImageSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15038;

        /// <summary>
        /// The identifier for the ImageSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint ImageSkillType_Halted_StateNumber = 15041;

        /// <summary>
        /// The identifier for the ImageSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint ImageSkillType_Ready_StateNumber = 15043;

        /// <summary>
        /// The identifier for the ImageSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint ImageSkillType_Running_StateNumber = 15045;

        /// <summary>
        /// The identifier for the ImageSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ImageSkillType_Suspended_StateNumber = 15047;

        /// <summary>
        /// The identifier for the ImageSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_HaltedToReady_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the ImageSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_ReadyToRunning_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_RunningToHalted_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_RunningToReady_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_RunningToSuspended_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_SuspendedToRunning_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_SuspendedToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_SuspendedToReady_TransitionNumber = 15063;

        /// <summary>
        /// The identifier for the ImageSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageSkillType_ReadyToHalted_TransitionNumber = 15065;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint ImageStreamSkillType_CurrentState_Id = 15074;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint ImageStreamSkillType_CurrentState_Number = 15076;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint ImageStreamSkillType_LastTransition_Id = 15079;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint ImageStreamSkillType_LastTransition_Number = 15081;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ImageStreamSkillType_LastTransition_TransitionTime = 15082;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_CreateSessionId = 15094;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_CreateClientName = 15095;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_InvocationCreationTime = 15096;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastTransitionTime = 15097;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodCall = 15098;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodSessionId = 15099;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodInputArguments = 15100;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15101;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodInputValues = 15102;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputValues = 15103;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodCallTime = 15104;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15105;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_Halted_StateNumber = 15108;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_Ready_StateNumber = 15110;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_Running_StateNumber = 15112;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_Suspended_StateNumber = 15114;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_HaltedToReady_TransitionNumber = 15116;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ReadyToRunning_TransitionNumber = 15118;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_RunningToHalted_TransitionNumber = 15120;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_RunningToReady_TransitionNumber = 15122;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_RunningToSuspended_TransitionNumber = 15124;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_SuspendedToRunning_TransitionNumber = 15126;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_SuspendedToHalted_TransitionNumber = 15128;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_SuspendedToReady_TransitionNumber = 15130;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ReadyToHalted_TransitionNumber = 15132;

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ParameterSet_FPS Variable.
        /// </summary>
        public const uint ImageStreamSkillType_ParameterSet_FPS = 15140;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint ImageFrameSkillType_CurrentState_Id = 15143;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint ImageFrameSkillType_CurrentState_Number = 15145;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint ImageFrameSkillType_LastTransition_Id = 15148;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint ImageFrameSkillType_LastTransition_Number = 15150;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ImageFrameSkillType_LastTransition_TransitionTime = 15151;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_CreateSessionId = 15163;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_CreateClientName = 15164;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_InvocationCreationTime = 15165;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastTransitionTime = 15166;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodCall = 15167;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodSessionId = 15168;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodInputArguments = 15169;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15170;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodInputValues = 15171;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputValues = 15172;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodCallTime = 15173;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15174;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_Halted_StateNumber = 15177;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_Ready_StateNumber = 15179;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_Running_StateNumber = 15181;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_Suspended_StateNumber = 15183;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_HaltedToReady_TransitionNumber = 15185;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ReadyToRunning_TransitionNumber = 15187;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_RunningToHalted_TransitionNumber = 15189;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_RunningToReady_TransitionNumber = 15191;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_RunningToSuspended_TransitionNumber = 15193;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_SuspendedToRunning_TransitionNumber = 15195;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_SuspendedToHalted_TransitionNumber = 15197;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_SuspendedToReady_TransitionNumber = 15199;

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ImageFrameSkillType_ReadyToHalted_TransitionNumber = 15201;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_Locked = 15219;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_LockingClient = 15220;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_LockingUser = 15221;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_RemainingLockTime = 15222;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock_InputArguments = 15224;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock_OutputArguments = 15225;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_RenewLock_OutputArguments = 15227;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_ExitLock_OutputArguments = 15229;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_BreakLock_OutputArguments = 15231;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_Locked = 15254;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_LockingClient = 15255;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_LockingUser = 15256;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RemainingLockTime = 15257;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 15259;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 15260;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 15262;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 15264;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 15266;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDevice_Lock_Locked = 15289;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDevice_Lock_LockingClient = 15290;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDevice_Lock_LockingUser = 15291;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDevice_Lock_RemainingLockTime = 15292;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock_InputArguments = 15294;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock_OutputArguments = 15295;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_RenewLock_OutputArguments = 15297;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_ExitLock_OutputArguments = 15299;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_BreakLock_OutputArguments = 15301;

        /// <summary>
        /// The identifier for the CameraDevice_Manufacturer Variable.
        /// </summary>
        public const uint CameraDevice_Manufacturer = 15302;

        /// <summary>
        /// The identifier for the CameraDevice_Model Variable.
        /// </summary>
        public const uint CameraDevice_Model = 15304;

        /// <summary>
        /// The identifier for the CameraDevice_HardwareRevision Variable.
        /// </summary>
        public const uint CameraDevice_HardwareRevision = 15305;

        /// <summary>
        /// The identifier for the CameraDevice_SoftwareRevision Variable.
        /// </summary>
        public const uint CameraDevice_SoftwareRevision = 15306;

        /// <summary>
        /// The identifier for the CameraDevice_DeviceRevision Variable.
        /// </summary>
        public const uint CameraDevice_DeviceRevision = 15307;

        /// <summary>
        /// The identifier for the CameraDevice_DeviceManual Variable.
        /// </summary>
        public const uint CameraDevice_DeviceManual = 15309;

        /// <summary>
        /// The identifier for the CameraDevice_SerialNumber Variable.
        /// </summary>
        public const uint CameraDevice_SerialNumber = 15311;

        /// <summary>
        /// The identifier for the CameraDevice_RevisionCounter Variable.
        /// </summary>
        public const uint CameraDevice_RevisionCounter = 15313;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_Locked = 15324;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_LockingClient = 15325;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_LockingUser = 15326;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RemainingLockTime = 15327;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock_InputArguments = 15329;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments = 15330;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments = 15332;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments = 15334;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments = 15336;

        /// <summary>
        /// The identifier for the CameraDevice_Image Variable.
        /// </summary>
        public const uint CameraDevice_Image = 15438;

        /// <summary>
        /// The identifier for the CameraDevice_CameraInfo Variable.
        /// </summary>
        public const uint CameraDevice_CameraInfo = 15427;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_CurrentState = 15351;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_CurrentState_Id = 15352;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_CurrentState_Number = 15354;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_LastTransition = 15356;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_LastTransition_Id = 15357;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_LastTransition_Number = 15359;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_LastTransition_TransitionTime = 15360;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Deletable Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_Deletable = 15364;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_AutoDelete Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_AutoDelete = 15365;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_RecycleCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_RecycleCount = 15366;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateSessionId = 15368;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateClientName = 15369;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_InvocationCreationTime = 15370;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastTransitionTime = 15371;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCall = 15372;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodSessionId = 15373;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputArguments = 15374;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputArguments = 15375;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputValues = 15376;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputValues = 15377;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCallTime = 15378;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodReturnStatus = 15379;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_MaxInstanceCount = 15381;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ParameterSet_FPS Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageStreamSkill_ParameterSet_FPS = 15388;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_CurrentState = 15390;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_CurrentState_Id = 15391;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_CurrentState_Number = 15393;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_LastTransition = 15395;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_LastTransition_Id = 15396;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_LastTransition_Number = 15398;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_LastTransition_TransitionTime = 15399;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Deletable Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_Deletable = 15403;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_AutoDelete Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_AutoDelete = 15404;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_RecycleCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_RecycleCount = 15405;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateSessionId = 15407;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateClientName = 15408;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_InvocationCreationTime = 15409;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastTransitionTime = 15410;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCall = 15411;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodSessionId = 15412;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputArguments = 15413;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputArguments = 15414;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputValues = 15415;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputValues = 15416;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCallTime = 15417;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodReturnStatus = 15418;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_ImageFrameSkill_MaxInstanceCount = 15420;
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
        /// The identifier for the CameraDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Halt = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageStreamSkill_Halt, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Reset = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageStreamSkill_Reset, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Resume = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageStreamSkill_Resume, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Suspend = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageStreamSkill_Suspend, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Start = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageStreamSkill_Start, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Halt = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageFrameSkill_Halt, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Reset = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageFrameSkill_Reset, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Resume = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageFrameSkill_Resume, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Suspend = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageFrameSkill_Suspend, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Start = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_ImageFrameSkill_Start, Camera.Namespaces.Camera);
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
        /// The identifier for the ImageStreamSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ParameterSet = new ExpandedNodeId(Camera.Objects.ImageStreamSkillType_ParameterSet, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ParameterSet = new ExpandedNodeId(Camera.Objects.ImageFrameSkillType_ParameterSet, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Camera.Objects.CameraDeviceType_CPIdentifier_NetworkAddress, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice = new ExpandedNodeId(Camera.Objects.CameraDevice, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_NetworkAddress = new ExpandedNodeId(Camera.Objects.CameraDevice_CPIdentifier_NetworkAddress, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_ImageStreamSkill, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ParameterSet = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_ImageStreamSkill_ParameterSet, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_ImageFrameSkill, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ParameterSet = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_ImageFrameSkill_ParameterSet, Camera.Namespaces.Camera);
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
        /// The identifier for the ImageSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType = new ExpandedNodeId(Camera.ObjectTypes.ImageSkillType, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType = new ExpandedNodeId(Camera.ObjectTypes.ImageStreamSkillType, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType = new ExpandedNodeId(Camera.ObjectTypes.ImageFrameSkillType, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType = new ExpandedNodeId(Camera.ObjectTypes.CameraDeviceType, Camera.Namespaces.Camera);
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
        /// The identifier for the ImageSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_CurrentState_Id = new ExpandedNodeId(Camera.Variables.ImageSkillType_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_CurrentState_Number = new ExpandedNodeId(Camera.Variables.ImageSkillType_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_LastTransition_Id = new ExpandedNodeId(Camera.Variables.ImageSkillType_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_LastTransition_Number = new ExpandedNodeId(Camera.Variables.ImageSkillType_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.ImageSkillType_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.ImageSkillType_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_Halted_StateNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_Halted_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_Ready_StateNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_Ready_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_Running_StateNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_Running_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_Suspended_StateNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_Suspended_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_HaltedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_ReadyToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_RunningToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_RunningToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_RunningToSuspended_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_SuspendedToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_SuspendedToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_SuspendedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageSkillType_ReadyToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_CurrentState_Id = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_CurrentState_Number = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_LastTransition_Id = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_LastTransition_Number = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_Halted_StateNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_Halted_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_Ready_StateNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_Ready_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_Running_StateNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_Running_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_Suspended_StateNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_Suspended_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_HaltedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ReadyToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_RunningToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_RunningToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_RunningToSuspended_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_SuspendedToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_SuspendedToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_SuspendedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ReadyToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageStreamSkillType_ParameterSet_FPS Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageStreamSkillType_ParameterSet_FPS = new ExpandedNodeId(Camera.Variables.ImageStreamSkillType_ParameterSet_FPS, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_CurrentState_Id = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_CurrentState_Number = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_LastTransition_Id = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_LastTransition_Number = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_Halted_StateNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_Halted_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_Ready_StateNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_Ready_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_Running_StateNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_Running_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_Suspended_StateNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_Suspended_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_HaltedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ReadyToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_RunningToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_RunningToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_RunningToSuspended_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_SuspendedToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_SuspendedToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_SuspendedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the ImageFrameSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageFrameSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.ImageFrameSkillType_ReadyToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Manufacturer = new ExpandedNodeId(Camera.Variables.CameraDevice_Manufacturer, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Model = new ExpandedNodeId(Camera.Variables.CameraDevice_Model, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_HardwareRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_HardwareRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_SoftwareRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_SoftwareRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_DeviceRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_DeviceRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_DeviceManual = new ExpandedNodeId(Camera.Variables.CameraDevice_DeviceManual, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_SerialNumber = new ExpandedNodeId(Camera.Variables.CameraDevice_SerialNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_RevisionCounter = new ExpandedNodeId(Camera.Variables.CameraDevice_RevisionCounter, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Image Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Image = new ExpandedNodeId(Camera.Variables.CameraDevice_Image, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CameraInfo = new ExpandedNodeId(Camera.Variables.CameraDevice_CameraInfo, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_CurrentState = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_CurrentState, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_CurrentState_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_CurrentState_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_LastTransition = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_LastTransition, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_LastTransition_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_LastTransition_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_Deletable = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_Deletable, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_AutoDelete = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_AutoDelete, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_RecycleCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_RecycleCount, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_MaxInstanceCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_MaxInstanceCount, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageStreamSkill_ParameterSet_FPS Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageStreamSkill_ParameterSet_FPS = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageStreamSkill_ParameterSet_FPS, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_CurrentState = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_CurrentState, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_CurrentState_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_CurrentState_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_LastTransition = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_LastTransition, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_LastTransition_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_LastTransition_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_Deletable = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_Deletable, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_AutoDelete = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_AutoDelete, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_RecycleCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_RecycleCount, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_ImageFrameSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_ImageFrameSkill_MaxInstanceCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_ImageFrameSkill_MaxInstanceCount, Camera.Namespaces.Camera);
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
        /// The BrowseName for the CameraDevice component.
        /// </summary>
        public const string CameraDevice = "CameraDevice";

        /// <summary>
        /// The BrowseName for the CameraDeviceType component.
        /// </summary>
        public const string CameraDeviceType = "CameraDeviceType";

        /// <summary>
        /// The BrowseName for the CameraInfo component.
        /// </summary>
        public const string CameraInfo = "CameraInfo";

        /// <summary>
        /// The BrowseName for the Image component.
        /// </summary>
        public const string Image = "Image";

        /// <summary>
        /// The BrowseName for the ImageFrameSkillType component.
        /// </summary>
        public const string ImageFrameSkillType = "ImageFrameSkillType";

        /// <summary>
        /// The BrowseName for the ImageSkillType component.
        /// </summary>
        public const string ImageSkillType = "ImageSkillType";

        /// <summary>
        /// The BrowseName for the ImageStreamSkillType component.
        /// </summary>
        public const string ImageStreamSkillType = "ImageStreamSkillType";
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
        /// The URI for the Camera namespace (.NET code namespace is 'Camera').
        /// </summary>
        public const string Camera = "https://pnp.org/UA/Camera/";

        /// <summary>
        /// The URI for the CameraXsd namespace (.NET code namespace is 'Camera').
        /// </summary>
        public const string CameraXsd = "https://pnp.org/UA/Camera/Types.xsd";

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