using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterFastTravelPointsRequest : gameScriptableSystemRequest
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;
		private CBool _register;

		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get
			{
				if (_fastTravelNodes == null)
				{
					_fastTravelNodes = (CArray<CHandle<gameFastTravelPointData>>) CR2WTypeManager.Create("array:handle:gameFastTravelPointData", "fastTravelNodes", cr2w, this);
				}
				return _fastTravelNodes;
			}
			set
			{
				if (_fastTravelNodes == value)
				{
					return;
				}
				_fastTravelNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CBool) CR2WTypeManager.Create("Bool", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		public RegisterFastTravelPointsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
