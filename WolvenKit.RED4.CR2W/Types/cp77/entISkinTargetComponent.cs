using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entISkinTargetComponent : entIVisualComponent
	{
		private CHandle<entSkinningBinding> _skinning;
		private CBool _useSkinningLOD;

		[Ordinal(8)] 
		[RED("skinning")] 
		public CHandle<entSkinningBinding> Skinning
		{
			get
			{
				if (_skinning == null)
				{
					_skinning = (CHandle<entSkinningBinding>) CR2WTypeManager.Create("handle:entSkinningBinding", "skinning", cr2w, this);
				}
				return _skinning;
			}
			set
			{
				if (_skinning == value)
				{
					return;
				}
				_skinning = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("useSkinningLOD")] 
		public CBool UseSkinningLOD
		{
			get
			{
				if (_useSkinningLOD == null)
				{
					_useSkinningLOD = (CBool) CR2WTypeManager.Create("Bool", "useSkinningLOD", cr2w, this);
				}
				return _useSkinningLOD;
			}
			set
			{
				if (_useSkinningLOD == value)
				{
					return;
				}
				_useSkinningLOD = value;
				PropertySet(this);
			}
		}

		public entISkinTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
