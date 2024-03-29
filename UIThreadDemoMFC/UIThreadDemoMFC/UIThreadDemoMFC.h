
// UIThreadDemoMFC.h : main header file for the UIThreadDemoMFC application
//
#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"       // main symbols


// CUIThreadDemoMFCApp:
// See UIThreadDemoMFC.cpp for the implementation of this class
//

class CUIThreadDemoMFCApp : public CWinAppEx
{
public:
	CUIThreadDemoMFCApp();


// Overrides
public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();

// Implementation

public:
	BOOL  m_bHiColorIcons;

	virtual void PreLoadState();
	virtual void LoadCustomState();
	virtual void SaveCustomState();

	afx_msg void OnAppAbout();
	DECLARE_MESSAGE_MAP()
};

extern CUIThreadDemoMFCApp theApp;
