using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Window : Door
	{
		private CHandle<entIComponent> _soloCollider;
		private CHandle<entMeshComponent> _strongSoloHandle;
		private CBool _duplicateDestruction;

		[Ordinal(135)] 
		[RED("soloCollider")] 
		public CHandle<entIComponent> SoloCollider
		{
			get
			{
				if (_soloCollider == null)
				{
					_soloCollider = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "soloCollider", cr2w, this);
				}
				return _soloCollider;
			}
			set
			{
				if (_soloCollider == value)
				{
					return;
				}
				_soloCollider = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("strongSoloHandle")] 
		public CHandle<entMeshComponent> StrongSoloHandle
		{
			get
			{
				if (_strongSoloHandle == null)
				{
					_strongSoloHandle = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "strongSoloHandle", cr2w, this);
				}
				return _strongSoloHandle;
			}
			set
			{
				if (_strongSoloHandle == value)
				{
					return;
				}
				_strongSoloHandle = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("duplicateDestruction")] 
		public CBool DuplicateDestruction
		{
			get
			{
				if (_duplicateDestruction == null)
				{
					_duplicateDestruction = (CBool) CR2WTypeManager.Create("Bool", "duplicateDestruction", cr2w, this);
				}
				return _duplicateDestruction;
			}
			set
			{
				if (_duplicateDestruction == value)
				{
					return;
				}
				_duplicateDestruction = value;
				PropertySet(this);
			}
		}

		public Window(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
