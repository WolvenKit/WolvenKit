using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialStep : CVariable
	{
		private CString _description;
		private CBool _showPointer;
		private CFloat _pointerRotation;
		private CFloat _pointerXPos;
		private CFloat _pointerYPos;
		private CArray<CName> _allowedActions;

		[Ordinal(0)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(1)] 
		[RED("showPointer")] 
		public CBool ShowPointer
		{
			get => GetProperty(ref _showPointer);
			set => SetProperty(ref _showPointer, value);
		}

		[Ordinal(2)] 
		[RED("pointerRotation")] 
		public CFloat PointerRotation
		{
			get => GetProperty(ref _pointerRotation);
			set => SetProperty(ref _pointerRotation, value);
		}

		[Ordinal(3)] 
		[RED("pointerXPos")] 
		public CFloat PointerXPos
		{
			get => GetProperty(ref _pointerXPos);
			set => SetProperty(ref _pointerXPos, value);
		}

		[Ordinal(4)] 
		[RED("pointerYPos")] 
		public CFloat PointerYPos
		{
			get => GetProperty(ref _pointerYPos);
			set => SetProperty(ref _pointerYPos, value);
		}

		[Ordinal(5)] 
		[RED("allowedActions")] 
		public CArray<CName> AllowedActions
		{
			get => GetProperty(ref _allowedActions);
			set => SetProperty(ref _allowedActions, value);
		}

		public TutorialStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
