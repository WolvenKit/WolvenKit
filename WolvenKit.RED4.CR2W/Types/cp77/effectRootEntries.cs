using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectRootEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectRootEntry> _roots;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get
			{
				if (_inheritRotation == null)
				{
					_inheritRotation = (CBool) CR2WTypeManager.Create("Bool", "inheritRotation", cr2w, this);
				}
				return _inheritRotation;
			}
			set
			{
				if (_inheritRotation == value)
				{
					return;
				}
				_inheritRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("roots")] 
		public CArray<effectRootEntry> Roots
		{
			get
			{
				if (_roots == null)
				{
					_roots = (CArray<effectRootEntry>) CR2WTypeManager.Create("array:effectRootEntry", "roots", cr2w, this);
				}
				return _roots;
			}
			set
			{
				if (_roots == value)
				{
					return;
				}
				_roots = value;
				PropertySet(this);
			}
		}

		public effectRootEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
