using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEntityEmitterSettings : RedBaseClass
	{
		private CName _emitterName;
		private CName _positionName;
		private CArray<CName> _emitterDecorators;
		private CBool _keepAlive;
		private CBool _isObjectPerPositionEmitter;

		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetProperty(ref _positionName);
			set => SetProperty(ref _positionName, value);
		}

		[Ordinal(2)] 
		[RED("emitterDecorators")] 
		public CArray<CName> EmitterDecorators
		{
			get => GetProperty(ref _emitterDecorators);
			set => SetProperty(ref _emitterDecorators, value);
		}

		[Ordinal(3)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get => GetProperty(ref _keepAlive);
			set => SetProperty(ref _keepAlive, value);
		}

		[Ordinal(4)] 
		[RED("isObjectPerPositionEmitter")] 
		public CBool IsObjectPerPositionEmitter
		{
			get => GetProperty(ref _isObjectPerPositionEmitter);
			set => SetProperty(ref _isObjectPerPositionEmitter, value);
		}
	}
}
