using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCData : animAnimFeature
	{
		private CBool _isDriver;
		private CInt32 _side;

		[Ordinal(0)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get
			{
				if (_isDriver == null)
				{
					_isDriver = (CBool) CR2WTypeManager.Create("Bool", "isDriver", cr2w, this);
				}
				return _isDriver;
			}
			set
			{
				if (_isDriver == value)
				{
					return;
				}
				_isDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CInt32) CR2WTypeManager.Create("Int32", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
				PropertySet(this);
			}
		}

		public AnimFeature_VehicleNPCData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
