using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformsSavedState : ISerializable
	{
		private CArray<entEntityID> _mapping;
		private CArray<gameMovingPlatformSavedData> _data;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<entEntityID> Mapping
		{
			get
			{
				if (_mapping == null)
				{
					_mapping = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "mapping", cr2w, this);
				}
				return _mapping;
			}
			set
			{
				if (_mapping == value)
				{
					return;
				}
				_mapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<gameMovingPlatformSavedData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<gameMovingPlatformSavedData>) CR2WTypeManager.Create("array:gameMovingPlatformSavedData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatformsSavedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
