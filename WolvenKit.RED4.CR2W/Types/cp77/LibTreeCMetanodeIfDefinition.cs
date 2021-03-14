using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCMetanodeIfDefinition : LibTreeCMetanodeDefinition
	{
		private LibTreeDefBool _ifCondition;
		private CHandle<LibTreeINodeDefinition> _ifBranch;
		private CHandle<LibTreeINodeDefinition> _elseBranch;

		[Ordinal(0)] 
		[RED("ifCondition")] 
		public LibTreeDefBool IfCondition
		{
			get
			{
				if (_ifCondition == null)
				{
					_ifCondition = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "ifCondition", cr2w, this);
				}
				return _ifCondition;
			}
			set
			{
				if (_ifCondition == value)
				{
					return;
				}
				_ifCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ifBranch")] 
		public CHandle<LibTreeINodeDefinition> IfBranch
		{
			get
			{
				if (_ifBranch == null)
				{
					_ifBranch = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "ifBranch", cr2w, this);
				}
				return _ifBranch;
			}
			set
			{
				if (_ifBranch == value)
				{
					return;
				}
				_ifBranch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("elseBranch")] 
		public CHandle<LibTreeINodeDefinition> ElseBranch
		{
			get
			{
				if (_elseBranch == null)
				{
					_elseBranch = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "elseBranch", cr2w, this);
				}
				return _elseBranch;
			}
			set
			{
				if (_elseBranch == value)
				{
					return;
				}
				_elseBranch = value;
				PropertySet(this);
			}
		}

		public LibTreeCMetanodeIfDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
