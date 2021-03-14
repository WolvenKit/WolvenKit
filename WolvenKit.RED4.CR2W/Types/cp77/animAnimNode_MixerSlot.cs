using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MixerSlot : animAnimNode_OnePoseInput
	{
		private CUInt16 _maxNormalAnimEntriesCount;
		private CUInt16 _maxAdditiveAnimEntriesCount;
		private CUInt16 _maxOverrideAnimEntriesCount;

		[Ordinal(12)] 
		[RED("maxNormalAnimEntriesCount")] 
		public CUInt16 MaxNormalAnimEntriesCount
		{
			get
			{
				if (_maxNormalAnimEntriesCount == null)
				{
					_maxNormalAnimEntriesCount = (CUInt16) CR2WTypeManager.Create("Uint16", "maxNormalAnimEntriesCount", cr2w, this);
				}
				return _maxNormalAnimEntriesCount;
			}
			set
			{
				if (_maxNormalAnimEntriesCount == value)
				{
					return;
				}
				_maxNormalAnimEntriesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("maxAdditiveAnimEntriesCount")] 
		public CUInt16 MaxAdditiveAnimEntriesCount
		{
			get
			{
				if (_maxAdditiveAnimEntriesCount == null)
				{
					_maxAdditiveAnimEntriesCount = (CUInt16) CR2WTypeManager.Create("Uint16", "maxAdditiveAnimEntriesCount", cr2w, this);
				}
				return _maxAdditiveAnimEntriesCount;
			}
			set
			{
				if (_maxAdditiveAnimEntriesCount == value)
				{
					return;
				}
				_maxAdditiveAnimEntriesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("maxOverrideAnimEntriesCount")] 
		public CUInt16 MaxOverrideAnimEntriesCount
		{
			get
			{
				if (_maxOverrideAnimEntriesCount == null)
				{
					_maxOverrideAnimEntriesCount = (CUInt16) CR2WTypeManager.Create("Uint16", "maxOverrideAnimEntriesCount", cr2w, this);
				}
				return _maxOverrideAnimEntriesCount;
			}
			set
			{
				if (_maxOverrideAnimEntriesCount == value)
				{
					return;
				}
				_maxOverrideAnimEntriesCount = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
