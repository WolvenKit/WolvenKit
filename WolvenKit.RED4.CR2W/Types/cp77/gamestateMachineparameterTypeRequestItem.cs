using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeRequestItem : IScriptable
	{
		private CArray<gameEquipParam> _requests;

		[Ordinal(0)] 
		[RED("requests")] 
		public CArray<gameEquipParam> Requests
		{
			get
			{
				if (_requests == null)
				{
					_requests = (CArray<gameEquipParam>) CR2WTypeManager.Create("array:gameEquipParam", "requests", cr2w, this);
				}
				return _requests;
			}
			set
			{
				if (_requests == value)
				{
					return;
				}
				_requests = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeRequestItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
