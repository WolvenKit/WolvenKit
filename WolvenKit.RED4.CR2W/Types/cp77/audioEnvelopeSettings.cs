using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEnvelopeSettings : audioAudioMetadata
	{
		private CFloat _attackTime;
		private CFloat _releaseTime;
		private CFloat _holdTime;

		[Ordinal(1)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get
			{
				if (_attackTime == null)
				{
					_attackTime = (CFloat) CR2WTypeManager.Create("Float", "attackTime", cr2w, this);
				}
				return _attackTime;
			}
			set
			{
				if (_attackTime == value)
				{
					return;
				}
				_attackTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("releaseTime")] 
		public CFloat ReleaseTime
		{
			get
			{
				if (_releaseTime == null)
				{
					_releaseTime = (CFloat) CR2WTypeManager.Create("Float", "releaseTime", cr2w, this);
				}
				return _releaseTime;
			}
			set
			{
				if (_releaseTime == value)
				{
					return;
				}
				_releaseTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("holdTime")] 
		public CFloat HoldTime
		{
			get
			{
				if (_holdTime == null)
				{
					_holdTime = (CFloat) CR2WTypeManager.Create("Float", "holdTime", cr2w, this);
				}
				return _holdTime;
			}
			set
			{
				if (_holdTime == value)
				{
					return;
				}
				_holdTime = value;
				PropertySet(this);
			}
		}

		public audioEnvelopeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
