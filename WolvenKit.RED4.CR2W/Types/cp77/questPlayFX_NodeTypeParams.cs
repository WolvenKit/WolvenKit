using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayFX_NodeTypeParams : CVariable
	{
		private CBool _play;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CName _effectName;
		private CUInt32 _sequenceShift;

		[Ordinal(0)] 
		[RED("play")] 
		public CBool Play
		{
			get => GetProperty(ref _play);
			set => SetProperty(ref _play, value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(4)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetProperty(ref _sequenceShift);
			set => SetProperty(ref _sequenceShift, value);
		}

		public questPlayFX_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
