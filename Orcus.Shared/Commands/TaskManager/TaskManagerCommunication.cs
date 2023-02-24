﻿namespace Orcus.Shared.Commands.TaskManager
{
    public enum TaskManagerCommunication : byte
    {
        SendKill,
        SendGetFullList,
        SendGetChanges,
        SetPriority,
        KillProcessTree,
        SuspendProcess,
        ResumeProcess,
        WindowBringToFront,
        WindowMinimize,
        WindowMaximize,
        WindowClose,
        WindowRestore,
        ResponseWindowActionDone,
        ResponseWindowActionFailed,
        ResponseFullList,
        ResponseChanges,
        ResponseTaskKilled,
        ResponseTaskKillFailed,
        ResponseSetPriorityFailed,
        ResponsePrioritySet,
        ResponseProcessTreeKilled,
        ResponseProcessSuspended,
        ResponseProcessResumed
    }
}