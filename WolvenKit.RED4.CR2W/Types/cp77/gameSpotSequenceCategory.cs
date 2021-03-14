using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSpotSequenceCategory : CVariable
	{
		private CEnum<gamedataWorkspotCategory> _type;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataWorkspotCategory> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataWorkspotCategory>) CR2WTypeManager.Create("gamedataWorkspotCategory", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		public gameSpotSequenceCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
