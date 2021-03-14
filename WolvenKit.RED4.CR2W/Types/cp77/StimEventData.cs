using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimEventData : CVariable
	{
		private wCHandle<gameObject> _source;
		private CEnum<gamedataStimType> _stimType;
		private CArray<CName> _tags;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public StimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
