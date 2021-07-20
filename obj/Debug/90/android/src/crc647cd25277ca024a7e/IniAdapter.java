package crc647cd25277ca024a7e;


public class IniAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("TUGAS5_D_672018025.IniAdapter, TUGAS5_D_672018025", IniAdapter.class, __md_methods);
	}


	public IniAdapter ()
	{
		super ();
		if (getClass () == IniAdapter.class)
			mono.android.TypeManager.Activate ("TUGAS5_D_672018025.IniAdapter, TUGAS5_D_672018025", "", this, new java.lang.Object[] {  });
	}

	public IniAdapter (android.content.Context p0, java.lang.String[] p1, java.lang.String[] p2, java.lang.String[] p3, java.lang.String[] p4, java.lang.String[] p5, int[] p6)
	{
		super ();
		if (getClass () == IniAdapter.class)
			mono.android.TypeManager.Activate ("TUGAS5_D_672018025.IniAdapter, TUGAS5_D_672018025", "Android.Content.Context, Mono.Android:System.String[], mscorlib:System.String[], mscorlib:System.String[], mscorlib:System.String[], mscorlib:System.String[], mscorlib:System.Int32[], mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3, p4, p5, p6 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
