using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPoliceCaller : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _caller;
		private Vector4 _crimePosition;

		[Ordinal(0)] 
		[RED("caller")] 
		public wCHandle<entEntity> Caller
		{
			get
			{
				if (_caller == null)
				{
					_caller = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "caller", cr2w, this);
				}
				return _caller;
			}
			set
			{
				if (_caller == value)
				{
					return;
				}
				_caller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("crimePosition")] 
		public Vector4 CrimePosition
		{
			get
			{
				if (_crimePosition == null)
				{
					_crimePosition = (Vector4) CR2WTypeManager.Create("Vector4", "crimePosition", cr2w, this);
				}
				return _crimePosition;
			}
			set
			{
				if (_crimePosition == value)
				{
					return;
				}
				_crimePosition = value;
				PropertySet(this);
			}
		}

		public RegisterPoliceCaller(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
