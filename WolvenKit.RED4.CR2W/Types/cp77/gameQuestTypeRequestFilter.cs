using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameQuestTypeRequestFilter : gameCustomRequestFilter
	{
		private CBool _includeMainQuests;
		private CBool _includeSideQuests;
		private CBool _includeStreetStories;
		private CBool _includeContracts;

		[Ordinal(0)] 
		[RED("includeMainQuests")] 
		public CBool IncludeMainQuests
		{
			get
			{
				if (_includeMainQuests == null)
				{
					_includeMainQuests = (CBool) CR2WTypeManager.Create("Bool", "includeMainQuests", cr2w, this);
				}
				return _includeMainQuests;
			}
			set
			{
				if (_includeMainQuests == value)
				{
					return;
				}
				_includeMainQuests = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("includeSideQuests")] 
		public CBool IncludeSideQuests
		{
			get
			{
				if (_includeSideQuests == null)
				{
					_includeSideQuests = (CBool) CR2WTypeManager.Create("Bool", "includeSideQuests", cr2w, this);
				}
				return _includeSideQuests;
			}
			set
			{
				if (_includeSideQuests == value)
				{
					return;
				}
				_includeSideQuests = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("includeStreetStories")] 
		public CBool IncludeStreetStories
		{
			get
			{
				if (_includeStreetStories == null)
				{
					_includeStreetStories = (CBool) CR2WTypeManager.Create("Bool", "includeStreetStories", cr2w, this);
				}
				return _includeStreetStories;
			}
			set
			{
				if (_includeStreetStories == value)
				{
					return;
				}
				_includeStreetStories = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("includeContracts")] 
		public CBool IncludeContracts
		{
			get
			{
				if (_includeContracts == null)
				{
					_includeContracts = (CBool) CR2WTypeManager.Create("Bool", "includeContracts", cr2w, this);
				}
				return _includeContracts;
			}
			set
			{
				if (_includeContracts == value)
				{
					return;
				}
				_includeContracts = value;
				PropertySet(this);
			}
		}

		public gameQuestTypeRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
