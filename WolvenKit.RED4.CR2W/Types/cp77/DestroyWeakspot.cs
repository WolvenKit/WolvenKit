using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspot : AIActionHelperTask
	{
		private CInt32 _weakspotIndex;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CArray<wCHandle<gameWeakspotObject>> _weakspotArray;

		[Ordinal(5)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get
			{
				if (_weakspotIndex == null)
				{
					_weakspotIndex = (CInt32) CR2WTypeManager.Create("Int32", "weakspotIndex", cr2w, this);
				}
				return _weakspotIndex;
			}
			set
			{
				if (_weakspotIndex == value)
				{
					return;
				}
				_weakspotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get
			{
				if (_weakspotComponent == null)
				{
					_weakspotComponent = (CHandle<gameWeakspotComponent>) CR2WTypeManager.Create("handle:gameWeakspotComponent", "weakspotComponent", cr2w, this);
				}
				return _weakspotComponent;
			}
			set
			{
				if (_weakspotComponent == value)
				{
					return;
				}
				_weakspotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weakspotArray")] 
		public CArray<wCHandle<gameWeakspotObject>> WeakspotArray
		{
			get
			{
				if (_weakspotArray == null)
				{
					_weakspotArray = (CArray<wCHandle<gameWeakspotObject>>) CR2WTypeManager.Create("array:whandle:gameWeakspotObject", "weakspotArray", cr2w, this);
				}
				return _weakspotArray;
			}
			set
			{
				if (_weakspotArray == value)
				{
					return;
				}
				_weakspotArray = value;
				PropertySet(this);
			}
		}

		public DestroyWeakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
