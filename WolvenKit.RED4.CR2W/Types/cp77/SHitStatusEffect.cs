using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitStatusEffect : CVariable
	{
		private CFloat _stacks;
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get
			{
				if (_stacks == null)
				{
					_stacks = (CFloat) CR2WTypeManager.Create("Float", "stacks", cr2w, this);
				}
				return _stacks;
			}
			set
			{
				if (_stacks == value)
				{
					return;
				}
				_stacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public SHitStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
