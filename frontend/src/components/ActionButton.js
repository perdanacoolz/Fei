import { Button, Stack } from '@mui/material'
import React from 'react'

const ActionButton = ({toggleEdit,DeleteData,props}) => {
    return (
        <Stack spacing={2} direction="row">
            <Button variant="contained" onClick={() => toggleEdit(props)}>
                Edit
            </Button>
            {/* color='error' */}
            <Button variant="contained" onClick={() => DeleteData(props)}> 
                Delete
            </Button>
        </Stack>
    )
}

export default ActionButton