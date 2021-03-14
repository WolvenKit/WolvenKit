using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_EffectDuration : animAnimEvent
	{
		private CName _effectName;
		private CUInt32 _sequenceShift;
		private CBool _breakAllLoopsOnStop;

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get
			{
				if (_sequenceShift == null)
				{
					_sequenceShift = (CUInt32) CR2WTypeManager.Create("Uint32", "sequenceShift", cr2w, this);
				}
				return _sequenceShift;
			}
			set
			{
				if (_sequenceShift == value)
				{
					return;
				}
				_sequenceShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("breakAllLoopsOnStop")] 
		public CBool BreakAllLoopsOnStop
		{
			get
			{
				if (_breakAllLoopsOnStop == null)
				{
					_breakAllLoopsOnStop = (CBool) CR2WTypeManager.Create("Bool", "breakAllLoopsOnStop", cr2w, this);
				}
				return _breakAllLoopsOnStop;
			}
			set
			{
				if (_breakAllLoopsOnStop == value)
				{
					return;
				}
				_breakAllLoopsOnStop = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_EffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
