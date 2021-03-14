using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		private animPoseLink _input;
		private CName _popSafeCutTag;

		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get
			{
				if (_input == null)
				{
					_input = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "Input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("popSafeCutTag")] 
		public CName PopSafeCutTag
		{
			get
			{
				if (_popSafeCutTag == null)
				{
					_popSafeCutTag = (CName) CR2WTypeManager.Create("CName", "popSafeCutTag", cr2w, this);
				}
				return _popSafeCutTag;
			}
			set
			{
				if (_popSafeCutTag == value)
				{
					return;
				}
				_popSafeCutTag = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkAnimContinue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
