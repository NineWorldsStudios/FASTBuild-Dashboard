﻿using System;

namespace FastBuild.Dashboard.Services.Worker
{
	internal interface IWorkerAgent
	{
		event EventHandler<WorkerRunStateChangedEventArgs> WorkerRunStateChanged;
		bool IsRunning { get; }
		void SetCoreCount(int coreCount);
        void SetThresholdValue(int threshold);
        void SetWorkerMode(WorkerMode mode);
		void Initialize();
		WorkerCoreStatus[] GetStatus();
	}
}
