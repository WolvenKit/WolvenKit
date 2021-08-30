using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioSecurityTurretMetadata : audioCustomEmitterMetadata
	{
		private CName _singleFire;
		private CName _activated;
		private CName _deactivaed;
		private CName _destroyed;
		private CName _idleStart;
		private CName _idleStop;
		private CBool _obstructionEnabled;
		private CBool _occlusionEnabled;

		[Ordinal(1)] 
		[RED("singleFire")] 
		public CName SingleFire
		{
			get => GetProperty(ref _singleFire);
			set => SetProperty(ref _singleFire, value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CName Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}

		[Ordinal(3)] 
		[RED("deactivaed")] 
		public CName Deactivaed
		{
			get => GetProperty(ref _deactivaed);
			set => SetProperty(ref _deactivaed, value);
		}

		[Ordinal(4)] 
		[RED("destroyed")] 
		public CName Destroyed
		{
			get => GetProperty(ref _destroyed);
			set => SetProperty(ref _destroyed, value);
		}

		[Ordinal(5)] 
		[RED("idleStart")] 
		public CName IdleStart
		{
			get => GetProperty(ref _idleStart);
			set => SetProperty(ref _idleStart, value);
		}

		[Ordinal(6)] 
		[RED("idleStop")] 
		public CName IdleStop
		{
			get => GetProperty(ref _idleStop);
			set => SetProperty(ref _idleStop, value);
		}

		[Ordinal(7)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get => GetProperty(ref _obstructionEnabled);
			set => SetProperty(ref _obstructionEnabled, value);
		}

		[Ordinal(8)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		public audioSecurityTurretMetadata()
		{
			_obstructionEnabled = true;
			_occlusionEnabled = true;
		}
	}
}
