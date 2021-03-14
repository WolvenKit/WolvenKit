using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigSharedData : CResource
	{
		private CArray<animRigPart> _parts;
		private CArray<CHandle<animIRigIkSetup>> _ikSetups;

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get
			{
				if (_parts == null)
				{
					_parts = (CArray<animRigPart>) CR2WTypeManager.Create("array:animRigPart", "parts", cr2w, this);
				}
				return _parts;
			}
			set
			{
				if (_parts == value)
				{
					return;
				}
				_parts = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get
			{
				if (_ikSetups == null)
				{
					_ikSetups = (CArray<CHandle<animIRigIkSetup>>) CR2WTypeManager.Create("array:handle:animIRigIkSetup", "ikSetups", cr2w, this);
				}
				return _ikSetups;
			}
			set
			{
				if (_ikSetups == value)
				{
					return;
				}
				_ikSetups = value;
				PropertySet(this);
			}
		}

		public animRigSharedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
