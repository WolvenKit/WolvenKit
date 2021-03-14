using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectBoneEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectBoneEntry> _bones;

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
		[RED("bones")] 
		public CArray<effectBoneEntry> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CArray<effectBoneEntry>) CR2WTypeManager.Create("array:effectBoneEntry", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		public effectBoneEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
