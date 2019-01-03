Public Class mQRCode
    Private _Data As String
    Private _PrimaryColor As Color
    Private _BackColor As Color
    Private _qWidth As Integer
    Private _qHeight As Integer

    Public Property Data As String
        Get
            Return _Data
        End Get
        Set
            _Data = Value
        End Set
    End Property

    Public Property PrimaryColor As Color
        Get
            Return _PrimaryColor
        End Get
        Set
            _PrimaryColor = Value
        End Set
    End Property

    Public Property BackColor As Color
        Get
            Return _BackColor
        End Get
        Set
            _BackColor = Value
        End Set
    End Property

    Public Property qWidth As Integer
        Get
            Return _qWidth
        End Get
        Set
            _qWidth = Value
        End Set
    End Property

    Public Property qHeight As Integer
        Get
            Return _qHeight
        End Get
        Set
            _qHeight = Value
        End Set
    End Property
End Class
